﻿/*
Copyright Upendo Ventures, LLC 

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), 
to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
DEALINGS IN THE SOFTWARE.
*/

namespace Upendo.Modules.DnnPageManager.Common
{
    public static class Constants
    {
        public static string ModuleName = "Upendo.Modules.DnnPageManager";
        public static string ModuleFolderName = "Upendo.Modules.DnnPageManager";

        public static string DesktopModules = "DesktopModules";
        public static string Resources = "App_LocalResources";

        public static string APIPath = string.Format("/{0}/{1}/API/", DesktopModules, ModuleName);

        public const string RESPONSE_SUCCESS = "IsSuccess";

        public const string ASC = "asc";
        public const string DESC = "desc";

        public const string SYSTEM = "System";
        public const string ACCOUNT = "Account";
        public const string AUTOMATIC = "Automatic";
        public const string VIEW = "VIEW";
        public const string EDIT = "EDIT";

        public const string FORMAT_DATE = "MM/dd/yyyy hh:mm";
        public const string FORMAT_LASTUPDATED = "{0} {1} {2}";
        
        public const string NAME = "name";
        public const string TITLE = "title";

        public const string ERROR_PAGE_NAME_REQUIRED = "Page name is required!";
        public const string ERROR_PAGE_PRIORITY_INVALID = "Invalid page priority";
        public const string ERROR_FORBIDDEN = "The user is not allowed to access this.";
    }

    public enum PublishStatus
    {
        All,
        Published,
        Draft
    }

    public enum TabFields
    {
        Name,
        Title,
        Description,
        Keywords,
        Priority,
        PrimaryURL,
        Visible,
        Indexed,
        Publishing
    }
}