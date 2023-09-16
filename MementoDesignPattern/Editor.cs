using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPattern
{
    public class Editor
    {
        private TextArea textArea;
        private Stack<TextAreaMemento> history;

        public Editor()
        {
            textArea = new TextArea();
            history = new Stack<TextAreaMemento>();
        }

        public string Write
        {
            get => textArea.text;
            set
            {
                //Push the returned Memento to the history stack before changing the state of 'text' string.
                history.Push(textArea.TakeSnapshot());

                // Set the 'text' string.
                textArea.text = value;
            }
        }

        public void Undo()
        {
            if (history.Count > 0)
            {
                // Restore to the previous state.
                var previousState = history.Pop();
                textArea.RestoreSnapshot(previousState);
            }
            else
            {
                Console.WriteLine("Nothing to undo.");
            }
        }

    }
}
