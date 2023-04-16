using System.Xml.Linq;

namespace AccountForms.DataModel
{
    public sealed class XmlDocument
    {
        private XmlDocument(string path)
        {
            _document = XDocument.Load(path);
            _root = _document.Root;
            DocumentPath = path;
        }

        private XDocument _document;
        private XElement? _root;

        public string DocumentPath { get; private set; }
        public bool IsExist { get; private set; }

        public IEnumerable<XElement?>? RootElements => _root?.Elements();

        public static XmlDocument LoadXmlDocument(string filePath)
        {
            return new XmlDocument(filePath);
        }

        public static XmlDocument CreateXmlDocument(string newFilePath, string root)
        {
            if (File.Exists(newFilePath))
            {
                throw new IOException("Фаил уже сужествует");
            }

            using (FileStream fs = File.Create(newFilePath))
            {
                AddPrologueAndRootToXmlDocument(fs, root);
            }

            return new XmlDocument(newFilePath);
        }

        private static void AddPrologueAndRootToXmlDocument(FileStream fileStream, string root)
        {
            using (StreamWriter sw = new StreamWriter(fileStream))
            {
                sw.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
                sw.WriteLine($"<{root}>\n</{root}>");
            }
        }

        public void AddElementToRoot(XElement element)
        {
            if (_root == null)
            {
                throw new NullReferenceException("Root is null");
            }

            _root?.Add(element);
            _document.Save(DocumentPath);
        }
    }
}
