using AppBancaMutual.ViewModels;

namespace AppBancaMutual.Infrastructure
{
    public class IntanceLocator
    {
        #region Properties
        public MainViewModel Main { get; set; }
        #endregion

        #region Constructors
        public IntanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion
    }
}
