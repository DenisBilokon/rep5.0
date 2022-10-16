using System;

namespace ConsoleApplication238
{
    class Program
    {
        private const string PRO_LICENSE = "111";
        private const string EXP_LICENSE = "222";

        static void Main(string[] args)
        {

            Console.WriteLine("Введiть лiцензiйний ключ:");
            var license = Console.ReadLine();


            DocumentWorker worker;
            switch (license)
            {
                case PRO_LICENSE: worker = new ProDocumentWorker(); break;
                case EXP_LICENSE: worker = new ExpertDocumentWorker(); break;
                default: worker = new DocumentWorker(); break;
            }


            while (true)
            {
                Console.WriteLine("Введiть команду (o/e/s/q): ");
                switch (Console.ReadLine())
                {
                    case "o": worker.OpenDocument(); break;
                    case "e": worker.EditDocument(); break;
                    case "s": worker.SaveDocument(); break;
                    case "q": return;
                }
            }
        }
    }

    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ вiдкрито");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Редагування документу доступно в версiї Про");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("зберiгання документу доступно в версiї Про");
        }
    }

    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ вiдреагован");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ збережен в старому форматi");
        }
    }

    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ збережен в новому форматi");
        }
    }
}

