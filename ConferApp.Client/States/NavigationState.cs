namespace ConferApp.Client.States
{
    public class NavigationState
    {
        public bool IsClicked { get; private set; } = false;

        public Action? BtnAction;

        public void BtnClicked()
        {
            IsClicked = true;
            BtnAction?.Invoke();
        }
    }
}
