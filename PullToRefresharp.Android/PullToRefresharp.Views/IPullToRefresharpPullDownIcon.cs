using System;

namespace PullToRefresharp.Android.Views
{
    public interface IPullToRefresharpPullDownIcon
    {
        /// <summary>
        /// Sets the pull down progress on the icon.
        /// </summary>
        /// <param name="progress">Progress is a value between 0 and 1.</param>
        void SetProgress(float progress);
    }
}

