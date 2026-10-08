namespace appdev.Models;

/// <summary>
/// Represents the aggregated community rating calculated from all reviews.
/// </summary>
public class CommunityRating
{
    /// <summary>The average score computed across all reviews.</summary>
    public float AverageScore { get; set; }

    /// <summary>The maximum possible score (e.g. 5).</summary>
    public int MaxScore { get; set; } = 5;

    /// <summary>
    /// Returns a formatted string representation of the community rating
    /// (e.g. "4.2 / 5").
    /// </summary>
    public string DisplayRating() => $"{AverageScore:F1} / {MaxScore}";
}
