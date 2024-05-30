using System;

   class Scripture
    {
        private Reference reference;
        private List<Words> words;

        public Scripture(Reference reference, string text)
        {
            this.reference = reference;
            words = text.Split(' ').Select(w => new Words(w)).ToList();
        }

        public bool HasWordsLeft()
        {
            return words.Any(w => !w.IsHidden);
        }

        public string GetMaskedText()
        {
            return reference.ToString() + "\n" + string.Join(" ", words.Select(w => w.GetMaskedWord()));
        }

        public void MaskRandomWord()
        {
            var unmaskedWords = words.Where(w => !w.IsHidden).ToList();
            if (unmaskedWords.Count > 0)
            {
                var random = new Random();
                var wordToMask = unmaskedWords[random.Next(unmaskedWords.Count)];
                wordToMask.Mask();
            }
        }
    }