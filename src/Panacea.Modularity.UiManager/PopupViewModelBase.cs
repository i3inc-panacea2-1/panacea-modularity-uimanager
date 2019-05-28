using Panacea.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.UiManager
{
    public abstract class PopupViewModelBase<TResult> : ViewModelBase
    {
        public PopupViewModelBase()
        {
            taskCompletionSource = new TaskCompletionSource<TResult>();
        }
        protected TaskCompletionSource<TResult> taskCompletionSource;

        public virtual Task<TResult> GetTask()
        {
            return taskCompletionSource.Task;
        }

        protected void SetResult(TResult result)
        {
            taskCompletionSource.SetResult(result);
        }

        protected virtual void Close()
        {
            SetResult(default(TResult));
        }
    }
}
