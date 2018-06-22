
namespace TodoApp
{
    using System;
    using System.Collections.Generic;

    public class MainViewModel : BaseViewModel
    {
        #region BackingFields
        private List<Todo> _todoes;

        #endregion
        #region Properties
        public List<Todo> Todoes
        {
            get { return _todoes; }
            set { SetValue(ref _todoes, value); }
        }

        #endregion
        #region Constructors
        public MainViewModel()
        {
            Get_Todoes();
        }
        #endregion
        #region Methods
        private void Get_Todoes()
        {
            Todoes = new List<Todo>()
            {
                new Todo
                {
                    Id = 1,
                    Description="Buy eggs",
                    IsDone = false,
                    UpdatedAT = DateTime.Now
                },
                new Todo
                {
                    Id = 2,
                    Description="Pay bills",
                    IsDone = false,
                    UpdatedAT = DateTime.Now
                },
                new Todo
                {
                    Id = 3,
                    Description="Read a book",
                    IsDone = false,
                    UpdatedAT = DateTime.Now
                },
            };

        }

        #endregion
    }
}
