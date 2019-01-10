namespace GixDotnet.Infrastructure.Services
{
    /// <summary>
    ///     Base request object to get endpoints which pagination and other metadata information.
    /// </summary>
    public abstract class BaseGetFilter : BaseFilter
    {
        private int _page;

        protected BaseGetFilter()
        {
            Page = 1;
        }

        /// <summary>
        ///     Requested page.
        /// </summary>
        public int Page
        {
            get => _page;
            set
            {
                Guard.Ensures(_page >= 1);
                _page = value;
            }
        }
    }
}