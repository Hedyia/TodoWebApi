
namespace TodoApp
{
    using System;
    using System.Collections.ObjectModel;
    using System.Threading.Tasks;

    public class MainViewModel : BaseViewModel
    {
        #region BackingFields
        private ObservableCollection<Todo> _todoes;
        private Service _apiService = new Service();
        #endregion
        #region Properties
        public ObservableCollection<Todo> Todoes
        {
            get { return _todoes; }
            set { SetValue( ref _todoes, value); }
        }

        #endregion
        #region Constructors
        public  MainViewModel()
        {
                
            Get_Todoes();
        }

        #endregion
        #region Methods

        private async Task Get_Todoes()
        {
            Todoes = await _apiService.GetData();
        }

        #endregion
    }
}
