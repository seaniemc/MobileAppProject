﻿#pragma checksum "C:\Users\Sean\Documents\Visual Studio 2015\Projects\WeatherAppProject\WeatherAppProject\ViewFrames\TenForecastFrame.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "736023DDD8E78D57AAD6A1A607586164"
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
    partial class WebcamFrame : 
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

        private class WebcamFrame_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IWebcamFrame_Bindings
        {
            private global::WeatherAppProject.ViewFrames.WebcamFrame dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ComboBox obj64;

            private WebcamFrame_obj1_BindingsTracking bindingsTracking;

            public WebcamFrame_obj1_Bindings()
            {
                this.bindingsTracking = new WebcamFrame_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 64:
                        this.obj64 = (global::Windows.UI.Xaml.Controls.ComboBox)target;
                        break;
                    default:
                        break;
                }
            }

            // IWebcamFrame_Bindings

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

            // WebcamFrame_obj1_Bindings

            public void SetDataRoot(global::WeatherAppProject.ViewFrames.WebcamFrame newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::WeatherAppProject.ViewFrames.WebcamFrame obj, int phase)
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
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj64, obj, null);
                }
            }
            private void Update_ReadInFile_SelectedIndex(global::System.Int32 obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_Selector_SelectedIndex(this.obj64, obj);
                }
            }

            private class WebcamFrame_obj1_BindingsTracking
            {
                global::System.WeakReference<WebcamFrame_obj1_Bindings> WeakRefToBindingObj; 

                public WebcamFrame_obj1_BindingsTracking(WebcamFrame_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<WebcamFrame_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_ReadInFile(null);
                }

                public void PropertyChanged_ReadInFile(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    WebcamFrame_obj1_Bindings bindings;
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
                    WebcamFrame_obj1_Bindings bindings;
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
                    WebcamFrame_obj1_Bindings bindings;
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
                    this.Weather20Image = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 3:
                {
                    this.Day20Text = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.Forecast20Text = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    this.Weather19Image = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 6:
                {
                    this.Day19Text = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7:
                {
                    this.Forecast19Text = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8:
                {
                    this.Weather18Image = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 9:
                {
                    this.Day18Text = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10:
                {
                    this.Forecast18Text = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11:
                {
                    this.Weather17Image = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 12:
                {
                    this.Day17Text = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13:
                {
                    this.Forecast17Text = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14:
                {
                    this.Weather16Image = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 15:
                {
                    this.Day16Text = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16:
                {
                    this.Forecast16Text = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 17:
                {
                    this.Weather15Image = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 18:
                {
                    this.Day15Text = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 19:
                {
                    this.Forecast15Text = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 20:
                {
                    this.Weather14Image = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 21:
                {
                    this.Day14Text = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 22:
                {
                    this.Forecast14Text = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 23:
                {
                    this.Weather13Image = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 24:
                {
                    this.Day13Text = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 25:
                {
                    this.Forecast13Text = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 26:
                {
                    this.Weather12Image = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 27:
                {
                    this.Day12Text = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 28:
                {
                    this.Forecast12Text = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 29:
                {
                    this.Weather11Image = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 30:
                {
                    this.Day11Text = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 31:
                {
                    this.Forecast11Text = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 32:
                {
                    this.Weather10Image = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 33:
                {
                    this.Day10Text = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 34:
                {
                    this.Forecast10Text = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 35:
                {
                    this.Weather9Image = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 36:
                {
                    this.Day9Text = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 37:
                {
                    this.Forecast9Text = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 38:
                {
                    this.Weather8Image = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 39:
                {
                    this.Day8Text = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 40:
                {
                    this.Forecast8Text = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 41:
                {
                    this.Weather7Image = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 42:
                {
                    this.Day7Text = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 43:
                {
                    this.Forecast7Text = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 44:
                {
                    this.Weather6Image = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 45:
                {
                    this.Day6Text = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 46:
                {
                    this.Forecast6Text = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 47:
                {
                    this.Weather5Image = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 48:
                {
                    this.Day5Text = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 49:
                {
                    this.Forecast5Text = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 50:
                {
                    this.Weather4Image = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 51:
                {
                    this.Day4Text = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 52:
                {
                    this.Forecast4Text = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 53:
                {
                    this.Weather3Image = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 54:
                {
                    this.Day3Text = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 55:
                {
                    this.Forecast3Text = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 56:
                {
                    this.Weather2Image = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 57:
                {
                    this.Day2Text = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 58:
                {
                    this.Forecast2Text = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 59:
                {
                    this.Weather1Image = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 60:
                {
                    this.Day1Text = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 61:
                {
                    this.Forecast1Text = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 62:
                {
                    this.CityTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 63:
                {
                    this.ConditionsButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 61 "..\..\..\ViewFrames\TenForecastFrame.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ConditionsButton).Click += this.ConditionsButton_Click;
                    #line default
                }
                break;
            case 64:
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
                    WebcamFrame_obj1_Bindings bindings = new WebcamFrame_obj1_Bindings();
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

