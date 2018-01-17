namespace HomePage.CustomControls
{
    public interface IMainCustomControl
    {
        bool IsValidated();
        object Value { get; }
        void SetValue(object newValue);
    }
}
