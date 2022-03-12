using System;

namespace Vecto.Images.Api
{
    public class ApplyImageDto
    {
        public PluginFieldDto[] Fields { get; set; } = Array.Empty<PluginFieldDto>();
    }
}