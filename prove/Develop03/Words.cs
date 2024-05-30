    using System;
    class Words
    {
        public string Text { get; private set; }
        public bool IsHidden { get; private set; }

        public Words(string text)
        {
            Text = text;
            IsHidden = false;
        }

        public void Mask()
        {
            IsHidden = true;
        }

        public string GetMaskedWord()
        {
            return IsHidden ? new string('_', Text.Length) : Text;
        }
    }