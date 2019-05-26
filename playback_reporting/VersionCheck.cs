﻿/*
Copyright(C) 2018

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program. If not, see<http://www.gnu.org/licenses/>.
*/

using MediaBrowser.Model.Updates;
using System;
using System.Collections.Generic;
using System.Text;

namespace playback_reporting
{
    public static class VersionCheck
    {
        public static bool IsVersionValid(Version app_version, PackageVersionClass server_update_level)
        {
            if (server_update_level != PackageVersionClass.Release)
            {
                return true;
            }
            else
            {
                return true;
            }
        }
    }
}
