namespace appdev.Services;

public class FilterItem
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Emoji { get; set; } = string.Empty;
    public string IconEmoji { get; set; } = string.Empty;
    public string ShortName { get; set; } = string.Empty;
    public string Color { get; set; } = "#ff69b4";
}

public class NyanStateService
{
    public List<FilterItem> Filters { get; } = new()
    {
        new FilterItem { Id = "cat-ears", Name = "Cat Ears + Lasers", ShortName = "Cat Ears", Emoji = "🐱", IconEmoji = "🐱", Color = "#ffb347" },
        new FilterItem { Id = "potato", Name = "Blushing Potato", ShortName = "Potato", Emoji = "🥔", IconEmoji = "🥔", Color = "#d2b48c" },
        new FilterItem { Id = "anime-eyes", Name = "Big Anime Eyes", ShortName = "Big Eyes", Emoji = "🥺", IconEmoji = "🥺", Color = "#87ceeb" },
        new FilterItem { Id = "blush", Name = "Blush", ShortName = "Blush", Emoji = "🌸", IconEmoji = "🌸", Color = "#ff9ec6" },
        new FilterItem { Id = "nyan-trail", Name = "Nyan Trail", ShortName = "Nyan", Emoji = "🌈", IconEmoji = "🌈", Color = "#ff69b4" },
        new FilterItem { Id = "star-power", Name = "Star Power", ShortName = "Stars", Emoji = "⭐", IconEmoji = "⭐", Color = "#ffd700" },
        new FilterItem { Id = "froggy", Name = "Froggy Mode", ShortName = "Froggy", Emoji = "🐸", IconEmoji = "🐸", Color = "#7bed9f" },
        new FilterItem { Id = "cat-girl", Name = "Cat Girl Madness", ShortName = "Cat Girl", Emoji = "🐱", IconEmoji = "🐱", Color = "#ffb347" },
        new FilterItem { Id = "senpai", Name = "Senpai Blush", ShortName = "Senpai", Emoji = "🥺", IconEmoji = "🥺", Color = "#ffb347" },
    };

    public string ActiveFilterId { get; set; } = "blush";

    public FilterItem ActiveFilter => Filters.FirstOrDefault(f => f.Id == ActiveFilterId) ?? Filters[3];

    // Settings
    public string CameraInput { get; set; } = "Built-in Camera";
    public string Resolution { get; set; } = "720p Cute ✨";
    public int FrameRate { get; set; } = 60;
    public bool ShowFaceMeshSparkles { get; set; } = true;
    public bool GpuTurboMode { get; set; } = false;
    public int MemeModelSensitivity { get; set; } = 65;
    public string SaveDirectory { get; set; } = "~/Movies/BoopCam";
    public string VideoFormat { get; set; } = "WEBM";

    public event Action? OnChange;

    public void SetActiveFilter(string filterId)
    {
        ActiveFilterId = filterId;
        NotifyStateChanged();
    }

    public void NotifyStateChanged() => OnChange?.Invoke();
}
