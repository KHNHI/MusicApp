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


    }
}
