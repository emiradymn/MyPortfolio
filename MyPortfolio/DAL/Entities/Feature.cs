using System;

namespace MyPortfolio.DAL.Entities;

public class Feature
{
    public int FeatureId { get; set; }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
}

