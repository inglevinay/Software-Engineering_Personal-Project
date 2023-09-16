using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPattern
{
    internal class TextArea
    {
        //for the demo _text is the internal state of TextArea.
        private string _text;

        public string text
        {
            get => _text = text; set => _text = value;
        }

        public TextAreaMemento TakeSnapshot()
        {
            return new TextAreaMemento(_text);
        }

        public void RestoreSnapshot(TextAreaMemento memento)
        {
            _text = memento.Text;
        }

    }
}
