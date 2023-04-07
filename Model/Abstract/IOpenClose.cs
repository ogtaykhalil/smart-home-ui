namespace Model.Abstract
{
    internal interface IOpenClose
    {
        bool OpenCommand { get; set; }
        bool CloseCommand { get; set; }
        void Switch();
        bool GetStatus();
    }
}
