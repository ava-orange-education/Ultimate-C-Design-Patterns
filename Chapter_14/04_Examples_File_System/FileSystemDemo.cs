namespace Chapter_14._04_Examples_File_System
{
    class FileSystemDemo
    {
        public void Run()
        {
            FileSystemEntry root = new FolderItem("Project");
            FileSystemEntry readme = new FileItem("README.md");
            FileSystemEntry src = new FolderItem("src");
            FileSystemEntry main = new FileItem("Main.cs");
            FileSystemEntry utils = new FileItem("Utils.cs");

            src.Add(main);
            src.Add(utils);
            root.Add(readme);
            root.Add(src);

            root.Display();
        }
    }
}
