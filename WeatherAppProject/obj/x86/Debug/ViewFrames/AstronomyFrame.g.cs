﻿#pragma checksum "C:\Users\Sean\Documents\Visual Studio 2015\Projects\WeatherAppProject\WeatherAppProject\ViewFrames\AstronomyFrame.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B0FE296FA8006C90D8A719D9EEACAC17"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WeatherAppProject.ViewFrames
{
    partial class AstronomyFrame : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_Selector_SelectedIndex(global::Windows.UI.Xaml.Controls.Primitives.Selector obj, global::System.Int32 value)
            {
                obj.SelectedIndex = value;
            }
        };

        private class AstronomyFrame_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IAstronomyFrame_Bindings
        {
            private global::WeatherAppProject.ViewFrames.AstronomyFrame dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ComboBox obj32;

            private AstronomyFrame_obj1_BindingsTracking bindingsTracking;

            public AstronomyFrame_obj1_Bindings()
            {
                this.bindingsTracking = new AstronomyFrame_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 32:
                        this.obj32 = (global::Windows.UI.Xaml.Controls.ComboBox)target;
                        break;
                    default:
                        break;
                }
            }

            // IAstronomyFrame_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            // AstronomyFrame_obj1_Bindings

            public void SetDataRoot(global::WeatherAppProject.ViewFrames.AstronomyFrame newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::WeatherAppProject.ViewFrames.AstronomyFrame obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ReadInFile(obj.ReadInFile, phase);
                    }
                }
            }
            private void Update_ReadInFile(global::WeatherAppProject.ViewModel.CountryCodesVM obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ReadInFile(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ReadInFile_CountryCodes(obj.CountryCodes, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ReadInFile_SelectedIndex(obj.SelectedIndex, phase);
                    }
                }
            }
            private void Update_ReadInFile_CountryCodes(global::System.Collections.ObjectModel.ObservableCollection<global::WeatherAppProject.ViewModel.CodesViewModel> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj32, obj, null);
                }
            }
            private void Update_ReadInFile_SelectedIndex(global::System.Int32 obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_Selector_SelectedIndex(this.obj32, obj);
                }
            }

            private class AstronomyFrame_obj1_BindingsTracking
            {
                global::System.WeakReference<AstronomyFrame_obj1_Bindings> WeakRefToBindingObj; 

                public AstronomyFrame_obj1_BindingsTracking(AstronomyFrame_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<AstronomyFrame_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_ReadInFile(null);
                }

                public void PropertyChanged_ReadInFile(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    AstronomyFrame_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::WeatherAppProject.ViewModel.CountryCodesVM obj = sender as global::WeatherAppProject.ViewModel.CountryCodesVM;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_ReadInFile_CountryCodes(obj.CountryCodes, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "CountryCodes":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ReadInFile_CountryCodes(obj.CountryCodes, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::WeatherAppProject.ViewModel.CountryCodesVM cache_ReadInFile = null;
                public void UpdateChildListeners_ReadInFile(global::WeatherAppProject.ViewModel.CountryCodesVM obj)
                {
                    if (obj != cache_ReadInFile)
                    {
                        if (cache_ReadInFile != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ReadInFile).PropertyChanged -= PropertyChanged_ReadInFile;
                            cache_ReadInFile = null;
                        }
                        if (obj != null)
                        {
                            cache_ReadInFile = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ReadInFile;
                        }
                    }
                }
                public void PropertyChanged_ReadInFile_CountryCodes(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    AstronomyFrame_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::System.Collections.ObjectModel.ObservableCollection<global::WeatherAppProject.ViewModel.CodesViewModel> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::WeatherAppProject.ViewModel.CodesViewModel>;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                        }
                        else
                        {
                            switch (propName)
                            {
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void CollectionChanged_ReadInFile_CountryCodes(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    AstronomyFrame_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::WeatherAppProject.ViewModel.CodesViewModel> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::WeatherAppProject.ViewModel.CodesViewModel>;
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2:
                {
                    this.MyProgressRing = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
                }
                break;
            case 3:
                {
                    this.WarmTempText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.WarmTempDescText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    this.WarmTempNameText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6:
                {
                    this.MidTempText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7:
                {
                    this.MidTempDescText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8:
                {
                    this.MidTempNameText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9:
                {
                    this.HighTempText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10:
                {
                    this.HighTempDescText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11:
                {
                    this.HighTempNameText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12:
                {
                    this.FreezingText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13:
                {
                    this.FreezingDescText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14:
                {
                    this.FreezingNameText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15:
                {
                    this.FogText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16:
                {
                    this.FogDescText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 17:
                {
                    this.FogNameText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 18:
                {
                    this.SnowText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 19:
                {
                    this.SnowDescText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 20:
                {
                    this.SnowNameText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 21:
                {
                    this.CloudTempText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 22:
                {
                    this.MostlyCloudsDescText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 23:
                {
                    this.MostlyCloudsText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 24:
                {
                    this.WindText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 25:
                {
                    this.WindNameText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 26:
                {
                    this.RainText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 27:
                {
                    this.RainDecText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 28:
                {
                    this.RainNameText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 29:
                {
                    this.ConditionsButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 47 "..\..\..\ViewFrames\AstronomyFrame.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ConditionsButton).Click += this.ConditionsButton_Click;
                    #line default
                }
                break;
            case 30:
                {
                    this.WeatherResultCityText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 31:
                {
                    this.CityTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 32:
                {
                    this.countryCombo = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    AstronomyFrame_obj1_Bindings bindings = new AstronomyFrame_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

