namespace MementoDesignPattern
{
    internal class TextAreaMemento
    {
        // The Text string should not be read-only, so has only the get accessor.
        public string Text { get; }

        public TextAreaMemento(string text)
        {
            Text = text;
        }

    }
}