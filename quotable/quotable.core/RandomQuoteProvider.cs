using System;
using System.Collections.Generic;
using System.Text;

namespace quotable.core
{
    /// <summary>
    /// Defines a Random Quote Provider
    /// </summary>
    interface RandomQuoteProvider
    {
        /// <summary>
        /// Computes the number it receives. "input"
        /// </summary>
        /// <param name="input"></param>
        /// <returns> The computed long. </returns>
        long ComputeNumber(long input);

        /// <summary>
        /// Creates the IEnumberable sequence.
        /// </summary>
        /// <param name="lng"></param>
        /// <returns> The IEnumerable sequence for the lng. </returns>
        IEnumerable<string> getQuote(long lng);

        /// <summary>
        /// Returns a unique identifier
        /// </summary>
        Guid ID { get; }
    }
}
