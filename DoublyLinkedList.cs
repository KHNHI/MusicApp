using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace Music
{
    internal class DoublyLinkedList
    {
        
        public SongNode Head { get; private set; } // Node đầu tiên
        public SongNode Tail { get; private set; } // Node cuối cùng
        public SongNode Current { get; set; }      // Node hiện tại
        public int Count { get; private set; }


        public void AddSong(string filePath, string fileName)
        {
            SongNode newNode = new SongNode(filePath, fileName);
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                newNode.Previous = Tail;
                Tail = newNode;
            }
            Count++;
        }

        public void MoveNext()
        {
            if (Current != null && Current.Next != null)
            {
                Current = Current.Next;
            }
            else
            {
                Current = null;
            }
        }

        public void MovePrevious()
        {
            if (Current != null && Current.Previous != null)
            {
                Current = Current.Previous;
            }
            else
            {
                Current = null;
            }
        }
        public void RemoveAt(int index)
        {
            if (Head == null || index < 0) return;
            SongNode current = Head;
            int count = 0;

            while (current != null)
            {
                if (count == index)
                {
                    if (current.Previous != null)
                        current.Previous.Next = current.Next;

                    if (current.Next != null)
                        current.Next.Previous = current.Previous;

                    if (current == Head)
                        Head = current.Next;

                    if (current == Tail)
                        Tail = current.Previous;

                    return;
                }

                current = current.Next;
                count++;
            }
        }
        public SongNode Search(string keyword)
        {
            SongNode current = Head; // Bắt đầu từ đầu danh sách
            while (current != null)
            {
                // So sánh bằng cách chuyển về chữ thường
                if (current.FileName.ToLower().Contains(keyword.ToLower()))
                {
                    return current; // Trả về Node tìm thấy
                }
                current = current.Next; // Di chuyển đến Node tiếp theo
            }
            return null; // Không tìm thấy
        }
        public void Swap(int index1, int index2)
        {
            if (index1 == index2 || Head == null) return;

            SongNode node1 = null, node2 = null, current = Head;
            int count = 0;

            // Tìm hai node cần hoán đổi
            while (current != null)
            {
                if (count == index1) node1 = current;
                if (count == index2) node2 = current;
                current = current.Next;
                count++;
            }

            // Nếu một trong hai node không tồn tại, thoát
            if (node1 == null || node2 == null) return;

            // Nếu hai node là kề nhau
            if (node1.Next == node2)
            {
                // Hoán đổi khi node1 đứng trước node2
                if (node1.Previous != null) node1.Previous.Next = node2;
                if (node2.Next != null) node2.Next.Previous = node1;

                node2.Previous = node1.Previous;
                node1.Next = node2.Next;
                node1.Previous = node2;
                node2.Next = node1;
            }
            else if (node2.Next == node1)
            {
                // Hoán đổi khi node2 đứng trước node1
                if (node2.Previous != null) node2.Previous.Next = node1;
                if (node1.Next != null) node1.Next.Previous = node2;

                node1.Previous = node2.Previous;
                node2.Next = node1.Next;
                node2.Previous = node1;
                node1.Next = node2;
            }
            else
            {
                // Hoán đổi các liên kết của node1 và node2 nếu không kề nhau
                if (node1.Previous != null) node1.Previous.Next = node2;
                if (node1.Next != null) node1.Next.Previous = node2;
                if (node2.Previous != null) node2.Previous.Next = node1;
                if (node2.Next != null) node2.Next.Previous = node1;

                // Hoán đổi Previous và Next
                var tempPrev = node1.Previous;
                var tempNext = node1.Next;
                node1.Previous = node2.Previous;
                node1.Next = node2.Next;
                node2.Previous = tempPrev;
                node2.Next = tempNext;
            }

            // Cập nhật Head và Tail nếu cần
            if (Head == node1) Head = node2;
            else if (Head == node2) Head = node1;

            if (Tail == node1) Tail = node2;
            else if (Tail == node2) Tail = node1;
        }




    }
}
