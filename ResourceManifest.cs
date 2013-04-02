using Orchard.UI.Resources;

namespace Piedone.BackgroundTaskViewer
{
    public class ResourceManifest : IResourceManifestProvider
    {

        public void BuildManifests(ResourceManifestBuilder builder)
        {
            var manifest = builder.Add();

            manifest
                .DefineScript("Piedone.BackgroundTaskViewer.Filtered")
                .SetUrl("background-task-lists-filtered.js")
                .SetDependencies("jQuery"); // That's why the feature depends on Orchard.jQuery
        }
    }
}