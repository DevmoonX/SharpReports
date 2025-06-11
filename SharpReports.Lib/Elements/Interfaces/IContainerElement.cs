using System;

namespace SharpReports.Lib.Elements.Interfaces;

public interface IContainerElement : IReportElements
{
    IList<IReportElements> Elements { get; }
}
