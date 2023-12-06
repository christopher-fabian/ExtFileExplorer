﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ExtFileExplorer.ViewModels;

internal abstract class ViewModelBase : INotifyPropertyChanged
{
  public event PropertyChangedEventHandler? PropertyChanged;

  protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
    => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}