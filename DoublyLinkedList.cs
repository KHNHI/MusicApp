using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
