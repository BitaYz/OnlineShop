﻿namespace OnlineShop.Application.Dtos.JWT
{
    public class PostBlacklistTokensAppDto
    {
        public Guid Id { get; set; }
        public string Token { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}
