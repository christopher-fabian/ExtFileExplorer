using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ExtFileExplorer.Models;

internal abstract class ModelBase : INotifyPropertyChanged
{
  public event PropertyChangedEventHandler? PropertyChanged;

  protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
    => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
