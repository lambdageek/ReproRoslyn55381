using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace Aleksey
{
    /// <summary>
    /// Enables rendering an HTML <c>&lt;title&gt;</c> to a <see cref="HeadOutlet"/> component.
    /// </summary>
    public sealed class PageTitleAK : ComponentBase
    {
        /// <summary>
        /// Gets or sets the content to be rendered as the document title.
        /// </summary>
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        /// <inheritdoc/>
        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "h1");
            ChildContent(builder);
            builder.CloseElement();
        }
    }
}