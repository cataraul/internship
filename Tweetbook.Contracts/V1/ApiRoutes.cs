﻿namespace TweetBook.Contract
{
    public static class ApiRoutes
    {
        public const string Root = "api";

        public const string Version = "v1";

        public const string Base = Root + "/" + Version;
        public static class Posts
        {
            public const string GetAll = Base +"/posts";

            public const string Update = Base + "/{postId}";

            public const string Delete = Base + "/{postId}";

            public const string Get = Base + "posts/{postId}";

            public const string Create = Base + "/posts";

        }
        public static class Identity
        {
            public const string Login = Base + "/identity/login";

            public const string Register = Base + "/identity/register";

            public const string Refresh = Base + "/identity/refresh";
        }

        public static class Tags
        {
            public const string TagsBase = Base + "/tags";

            public const string Delete = Base + "/tags/{tagName}";
        }
    }
}
