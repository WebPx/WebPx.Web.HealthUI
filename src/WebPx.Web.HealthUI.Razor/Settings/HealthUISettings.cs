namespace WebPx.Web.HealthUI.Razor.Settings
{
    /// <summary>
    /// Class that contains settings for the HealthUI component
    /// </summary>
    public sealed class HealthUISettings()
    {
        /// <summary>
        /// Gets or sets the base URI for the HealthUI layout page
        /// </summary>
        public string? BaseUri { get; set; }

        /// <summary>
        /// Gets or sets the path to the bootstrap folder
        /// </summary>
        public string? BootstrapPath { get; set; }

        /// <summary>
        /// Gets or sets the path to the bootstrap icon folder
        /// </summary>
        public string? BootstrapIconPath { get; set; }
    }
}