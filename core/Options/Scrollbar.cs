using System;
using System.Drawing;
using DotNet.HighStock.Enums;
using DotNet.HighStock.Attributes;
using DotNet.HighStock.Helpers;

namespace DotNet.HighStock.Options
{
    /// <summary>
    /// The scrollbar is a means of panning over the X axis of a chart.
    /// </summary>
    public class Scrollbar
    {

        /// <summary>
        /// The background color of the scrollbar itself. 
        /// Defaults to #bfc8d1.
        /// </summary>
        public Color? BarBackgroundColor
        {
            get;
            set;
        }

        /// <summary>
        /// The color of the scrollbar's border. 
        /// Defaults to #bfc8d1.
        /// </summary>
        public Color? BarBorderColor
        {
            get;
            set;
        }

        /// <summary>
        /// The border rounding radius of the bar. 
        /// Defaults to 0.
        /// </summary>
        public Number? BarBorderRadius
        {
            get;
            set;
        }

        /// <summary>
        /// The width of the bar's border. 
        /// Defaults to 1.
        /// </summary>
        public Number? BarBorderWidth
        {
            get;
            set;
        }

        /// <summary>
        /// The color of the small arrow inside the scrollbar buttons. 
        /// Defaults to #666.
        /// </summary>
        public Color? ButtonArrowColor
        {
            get;
            set;
        }

        /// <summary>
        /// The color of scrollbar buttons. 
        /// Defaults to #ebe7e8.
        /// </summary>
        public Color? ButtonBackgroundColor
        {
            get;
            set;
        }

        /// <summary>
        /// The color of the border of the scrollbar buttons. 
        /// Defaults to #bbbbbb.
        /// </summary>
        public Color? ButtonBorderColor
        {
            get;
            set;
        }

        /// <summary>
        /// The corner radius of the scrollbar buttons. 
        /// Defaults to 0.
        /// </summary>
        public Number? ButtonBorderRadius
        {
            get;
            set;
        }

        /// <summary>
        /// The border width of the scrollbar buttons. 
        /// Defaults to 1.
        /// </summary>
        public Number? ButtonBorderWidth
        {
            get;
            set;
        }

        /// <summary>
        /// Enable or disable the scrollbar. 
        /// Defaults to true.
        /// </summary>
        public bool? Enabled
        {
            get;
            set;
        }

        /// <summary>
        /// The height of the scrollbar. The height also applies to the width of the scroll arrows so that they are always squares. 
        /// Defaults to 20 for touch devices and 14 for mouse devices.
        /// </summary>
        public Number? Height
        {
            get;
            set;
        }

        /// <summary>
        /// Whether to redraw the main chart as the scrollbar or the navigator zoomed window is moved. 
        /// Defaults to true for modern browsers and false for legacy IE browsers as well as mobile devices.
        /// </summary>
        public bool? LiveRedraw
        {
            get;
            set;
        }

        /// <summary>
        /// The minimum width of the scrollbar. 
        /// Defaults to 6.
        /// </summary>
        public Number? MinWidth
        {
            get;
            set;
        }

        /// <summary>
        /// The color of the small rifles in the middle of the scrollbar. 
        /// Defaults to #666.
        /// </summary>
        public Color? RifleColor
        {
            get;
            set;
        }

        /// <summary>
        /// The color of the track background. 
        /// Defaults to #eeeeee.
        /// </summary>
        public Color? TrackBackgroundColor
        {
            get;
            set;
        }

        /// <summary>
        /// The color of the border of the scrollbar track. 
        /// Defaults to #eeeeee.
        /// </summary>
        public Color? TrackBorderColor
        {
            get;
            set;
        }

        /// <summary>
        /// The corner radius of the border of the scrollbar track. 
        /// Defaults to 0.
        /// </summary>
        public Number? TrackBorderRadius
        {
            get;
            set;
        }

        /// <summary>
        /// The width of the border of the scrollbar track. 
        /// Defaults to 1.
        /// </summary>
        public Number? TrackBorderWidth
        {
            get;
            set;
        }
    }
}