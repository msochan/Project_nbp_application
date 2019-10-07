using System;
using System.Windows.Input;

namespace Projekt_nbp_CodeFirst.Internal
{

    public class RelayCommand : ICommand
    {
        /// <summary>
        /// The execute delegate injected by user of class.
        /// </summary>
        private readonly Action<object> execute;

        /// <summary>
        /// The can execute delegate injected by user of the class.
        /// </summary>
        private readonly Func<object, bool> canExecute;

        /// <summary>
        /// The constructor taking execute and can execute delegates defined by user.
        /// </summary>
        /// <param name="execute">The execute delegate.</param>
        /// <param name="canExecute">The canExecute delegate.</param>
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        /// <summary>
        /// The constructor taking only execute delegate defined by user.
        /// </summary>
        /// <param name="execute">The execute delegate.</param>
        public RelayCommand(Action<object> execute)
            : this(execute, null)
        {

        }

        /// <summary>
        /// The constructor taking execute and can execute delegates defined by user.
        /// </summary>
        /// <param name="execute">The execute delegate.</param>
        /// <param name="canExecute">The canExecute delegate.</param>
        public RelayCommand(Action execute, Func<object, bool> canExecute)
            : this(x => execute(), canExecute)
        {

        }

        /// <summary>
        /// The constructor taking only execute delegate defined by user.
        /// </summary>
        /// <param name="execute">The execute delegate.</param>
        public RelayCommand(Action execute)
            : this(x => execute(), null)
        {

        }

        /// <summary>
        /// Checks whether action of this command can be executed.
        /// </summary>
        /// <param name="parameter">Can execute parameter.</param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            if (null == this.canExecute)
            {
                return true;
            }

            return this.canExecute(parameter);
        }

        /// <summary>
        /// Event raised when state of can execute got changed.
        /// </summary>
        public event EventHandler CanExecuteChanged = null;

        /// <summary>
        /// The Execute function, calling users delegate
        /// </summary>
        /// <param name="parameter">Execute parameter.</param>
        public void Execute(object parameter)
        {
            execute?.Invoke(parameter);
        }

        /// <summary>
        /// Raisec the change of can execute.
        /// </summary>
        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}