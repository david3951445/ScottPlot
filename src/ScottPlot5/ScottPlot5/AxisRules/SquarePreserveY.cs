﻿namespace ScottPlot.AxisRules;

public class SquarePreserveY : IAxisRule
{
    readonly IXAxis XAxis;
    readonly IYAxis YAxis;

    public SquarePreserveY(IXAxis xAxis, IYAxis yAxis)
    {
        XAxis = xAxis;
        YAxis = yAxis;
    }

    public void Apply(RenderPack rp)
    {
        double unitsPerPxY = YAxis.Height / rp.DataRect.Height;
        double halfWidth = rp.DataRect.Width / 2 * unitsPerPxY;
        double xMin = XAxis.Range.Center - halfWidth;
        double xMax = XAxis.Range.Center + halfWidth;
        XAxis.Range.Set(xMin, xMax);
    }
}
