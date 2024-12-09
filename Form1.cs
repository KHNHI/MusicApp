﻿using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Music
{
    public partial class Form1 : Form
    {
        DoublyLinkedList doublyLinkedList = new DoublyLinkedList();
        //private Timer timer;

        public Form1()
        {

            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            //splitContainer1.Dock = DockStyle.Fill;
            // axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.PlayStateChange += axWindowsMediaPlayer1_PlayStateChange;
            //timer = new Timer();
            //timer.Interval = 1000;
            // timer.Tick += Timer_Tick;
            //timer.Start();
            // guna2TrackBar1.ValueChanged += guna2TrackBar1_ValueChanged;
        }


        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            // Điều chỉnh kích thước các thành phần nếu cần
            listBox1.Width = splitContainer1.Panel1.Width; // Cập nhật ListBox theo Panel1
            axWindowsMediaPlayer1.Width = splitContainer1.Panel2.Width; // Cập nhật Media Player theo Panel2
        }
        OpenFileDialog openFileDialog;
        string[] filePaths;
        string[] fileNames;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Mp3 files, mp4 files(*.mp3, *.mp4)|*.mp*";
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "Select Music Files";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] filePaths = openFileDialog.FileNames;
                string[] fileNames = openFileDialog.SafeFileNames;

                for (int i = 0; i < filePaths.Length; i++)
                {
                    doublyLinkedList.AddSong(filePaths[i], fileNames[i]); // Thêm vào playlist
                    this.listBox1.Items.Add(fileNames[i]);       // Hiển thị trong listBox
                }
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int selectedIndex = listBox1.SelectedIndex;
                doublyLinkedList.Current = doublyLinkedList.Head;

                // Tìm bài hát tương ứng trong danh sách
                for (int i = 0; i < selectedIndex; i++)
                {
                    doublyLinkedList.Current = doublyLinkedList.Current.Next;
                }

                // Phát bài hát
                axWindowsMediaPlayer1.URL = doublyLinkedList.Current.FilePath;
                // textBox1.Text = doublyLinkedList.Current.FileName;
                btnPlay.BackgroundImage = Properties.Resources.pauseIcon;
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (doublyLinkedList.Current != null)
            {
                // Di chuyển đến bài hát tiếp theo
                doublyLinkedList.MoveNext();

                // Kiểm tra nếu đã đến bài hát cuối cùng
                if (doublyLinkedList.Current == null)
                {
                    // Nếu đã hết playlist, quay lại bài hát đầu tiên
                    doublyLinkedList.Current = doublyLinkedList.Head;
                }

                // Phát bài hát tiếp theo hoặc quay lại đầu tiên
                if (doublyLinkedList.Current != null)
                {
                    axWindowsMediaPlayer1.URL = doublyLinkedList.Current.FilePath;
                    //  textBox1.Text = doublyLinkedList.Current.FileName;
                }
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (doublyLinkedList.Current != null)
            {
                doublyLinkedList.MovePrevious();
                if (doublyLinkedList.Current == null)
                {
                    doublyLinkedList.Current = doublyLinkedList.Tail;
                }
                if (doublyLinkedList.Current != null)
                {
                    axWindowsMediaPlayer1.URL = doublyLinkedList.Current.FilePath;
                    //  textBox1.Text = doublyLinkedList.Current.FileName;
                }
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomIndex = random.Next(0, listBox1.Items.Count);

            doublyLinkedList.Current = doublyLinkedList.Head;

            // Tìm bài hát ngẫu nhiên
            for (int i = 0; i < randomIndex; i++)
            {
                doublyLinkedList.Current = doublyLinkedList.Current.Next;
            }

            // Phát bài hát
            axWindowsMediaPlayer1.URL = doublyLinkedList.Current.FilePath;
            //textBox1.Text = doublyLinkedList.Current.FileName;
        }
        private bool isButtonClick = false; // Cờ xác định thay đổi do nút nhấn

        private void btnPlay_Click(object sender, EventArgs e)
        {
            isButtonClick = true; // Đánh dấu trạng thái được thay đổi bởi nút nhấn

            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                // Tạm dừng nhạc và đổi biểu tượng sang Play
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                btnPlay.BackgroundImage = Properties.Resources.playIcon;
                //timer.Stop();
            }
            else
            {
                // Phát nhạc và đổi biểu tượng sang Pause
                axWindowsMediaPlayer1.Ctlcontrols.play();
                btnPlay.BackgroundImage = Properties.Resources.pauseIcon;
                //timer.Start();
            }
            btnPlay.Refresh(); // Cập nhật giao diện
            isButtonClick = false; // Hoàn thành xử lý nút nhấn
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (isButtonClick) return; // Bỏ qua nếu trạng thái thay đổi do nút nhấn

            if (e.newState == (int)WMPLib.WMPPlayState.wmppsPlaying)
            {
                btnPlay.BackgroundImage = Properties.Resources.pauseIcon; // Biểu tượng Pause
            }
            else if (e.newState == (int)WMPLib.WMPPlayState.wmppsPaused ||
                     e.newState == (int)WMPLib.WMPPlayState.wmppsStopped)
            {
                btnPlay.BackgroundImage = Properties.Resources.playIcon; // Biểu tượng Play
            }
            btnPlay.Refresh(); // Cập nhật giao diện
        }

        private void btnRemoveSong_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int selectedIndex = listBox1.SelectedIndex;

                // Xóa bài hát khỏi danh sách liên kết kép
                doublyLinkedList.RemoveAt(selectedIndex);

                // Xóa bài hát khỏi ListBox
                listBox1.Items.RemoveAt(selectedIndex);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một bài hát để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtbSong.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SongNode result = doublyLinkedList.Search(keyword);

            if (result != null)
            {
                // Nếu tìm thấy bài hát, chọn trong ListBox và hiển thị thông tin
                int index = listBox1.Items.IndexOf(result.FileName); // Lấy chỉ số bài hát trong ListBox
                listBox1.SelectedIndex = index; // Chọn bài hát
                MessageBox.Show($"Đã tìm thấy bài hát: {result.FileName}", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy bài hát nào phù hợp.", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

