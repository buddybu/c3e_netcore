using System;
using System.Diagnostics;

namespace SourceGrid.Exporter
{
    [Obsolete("Please use CsvExporter class instead. This will be removed in future releases")]
    public class CSV : CsvExporter
    {
    }

    /// <summary>
    /// An utility class to export a grid to a csv delimited format file.
    /// </summary>
    public class CsvExporter
    {
        private const string QUOTE = "\"";
        private const string ESCAPED_QUOTE = "\"\"";
        private static char[] CHARACTERS_THAT_MUST_BE_QUOTED = { ',', '"', '\n' };

        public CsvExporter()
        {
            mFieldSeparator = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator;
            mLineSeparator = System.Environment.NewLine;
        }

        private string mFieldSeparator;
        public string FieldSeparator
        {
            get { return mFieldSeparator; }
            set { mFieldSeparator = value; }
        }
        private string mLineSeparator;
        public string LineSeparator
        {
            get { return mLineSeparator; }
            set { mLineSeparator = value; }
        }

        public virtual void Export(GridVirtual grid, System.IO.TextWriter stream)
        {
            for (var r = 0; r < grid.Rows.Count; r++)
            {
                for (var c = 0; c < grid.Columns.Count; c++)
                {
                    if (c > 0)
                        stream.Write(mFieldSeparator);

                    var cell = grid.GetCell(r, c);
                    var pos = new Position(r, c);
                    var context = new CellContext(grid, pos, cell);
                    ExportCsvCell(context, stream);
                }
                if (IsLastLine(grid, r) == false)
                    stream.Write(mLineSeparator);
            }
        }

        private bool IsLastLine(GridVirtual grid, int i)
        {
            return grid.Rows.Count -1 == i;
        }

        private void ExportCsvCell(CellContext context, System.IO.TextWriter stream)
        {
            var text = string.Empty;
            if (context.Cell != null)
                text = context.DisplayText ?? string.Empty;
            if (text.Contains(QUOTE))
                text = text.Replace(QUOTE, ESCAPED_QUOTE);
            if (text.IndexOfAny(CHARACTERS_THAT_MUST_BE_QUOTED) > -1)
                text = QUOTE + text + QUOTE;
            stream.Write(text);
        }
    }

}
