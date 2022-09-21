﻿namespace cbb.ui
{
    /// <summary>
    /// Interaction logic for PreferencesPage.xaml
    /// </summary>
    /// <seealso cref="cbb.ui.BasePage" />
    /// <seealso cref="System.Windows.Markup.IComponentConnector" />
    public partial class PreferencesPage : BasePage
    {
        #region constructor

        /// <summary>
        /// Default constructor.
        /// Initializes a new instance of the <see cref="PreferencesPage"/> class.
        /// </summary>
        public PreferencesPage()
        {
            InitializeComponent();

            Animation = PageAnimationType.Fade;
        }

        #endregion
    }
}
