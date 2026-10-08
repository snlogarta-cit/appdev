namespace appdev.Models;

/// <summary>
/// Represents a user-submitted review for a feature or experience.
/// </summary>
public class Review
{
    /// <summary>The user's display handle (username).</summary>
    public string Handle { get; set; } = string.Empty;

    /// <summary>The avatar chosen by the user.</summary>
    public Avatar Avatar { get; set; } = Avatar.CAT;

    /// <summary>The feature category this review is tagged under.</summary>
    public FeatureTag FeatureTag { get; set; } = FeatureTag.GENERAL_EXPERIENCE;

    /// <summary>The numeric rating given by the user (e.g. 1–5).</summary>
    public int Rating { get; set; }

    /// <summary>The written comment body of the review.</summary>
    public string Comment { get; set; } = string.Empty;
}
