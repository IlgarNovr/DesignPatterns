using System;

namespace State
{
    interface IState
    {
        void Render();

        void Publish();

        void Draft();
    }

    class Document
    {
        private IState _state;

        public Document()
        {
            _state = new Moderation(this);
        }

        public void Render()
        {
            _state.Render();
        }

        public void Publish()
        {
            _state.Publish();
        }

        public void Draft()
        {
            _state.Draft();
        }

        public void ChangeState(IState state)
        {
            _state = state;
        }
    }

    class Drafted : IState
    {
        private Document _document;

        public void Publish()
        {
            Console.WriteLine("Document Drafted Publised");
            _document.ChangeState(new Published(_document));
        }

        public void Render()
        {
            Console.WriteLine("Document Drafted Moderation");
            _document.ChangeState(new Moderation(_document));
        }

        public void Draft()
        {
            Console.WriteLine("Drafted");
        }

        public Drafted(Document document)
        {
            _document = document;
        }
    }

    class Published : IState
    {
        private Document _document;

        public void Publish()
        {
            Console.WriteLine("Published");
        }

        public void Render()
        {
            Console.WriteLine("Document Published Moderation");
            _document.ChangeState(new Moderation(_document));
        }

        public void Draft()
        {
            Console.WriteLine("Document Published Drafted");
            _document.ChangeState(new Drafted(_document));
        }

        public Published(Document document)
        {
            _document = document;
        }
    }

    class Moderation : IState
    {
        private Document _document;

        public void Draft()
        {
            Console.WriteLine("Document Moderation Drafted");
            _document.ChangeState(new Drafted(_document));

        }

        public void Publish()
        {
            Console.WriteLine("Document Moderation Publised");
            _document.ChangeState(new Published(_document));
        }

        public void Render()
        {
            Console.WriteLine("Rendering");
        }

        public Moderation(Document document)
        {
            _document = document;
        }
    }
}