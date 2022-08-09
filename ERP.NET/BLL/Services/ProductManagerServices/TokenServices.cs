using BLL.Entities;
using DAL.DataAccessFactory;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.ProductManagerServices
{
    public class TokenServices
    {
        public static TokenModel create(int id)
        {
            var token = new Token()
            {
                Token1 = GetToken(),
                UserId = id,
                CreatedAt = DateTime.Now
            };
            var data = DataAccessFactory.ProductManagerTokenDataAccess().Create(token);
            var newToken = new TokenModel()
            {
                id = data.id,
                CreatedAt = data.CreatedAt,
                Token1 = data.Token1,
                UserId = data.UserId
            };
            return newToken;
        }
        public static string GetToken()
        {
            Random res = new Random();
            String str = "abcdefghijklmnopqrstuvwxyz";
            String ran = "";
            for(int i=0;i<40;i++)
            {
                int ind = res.Next(25);
                ran = ran + str[ind];
            }
            string num = "0123456789";
            for(int i=0;i<20;i++)
            {
                int ind = res.Next(9);
                ran = ran + num[ind];
            }
            return ran;
        }
        public static bool Delete(string token)
        {
            return DataAccessFactory.ProductManagerTokenDataAccess().Delete(token);
        }


        public static List<TokenModel> Get()
        {
            var data = DataAccessFactory.ProductManagerTokenDataAccess().Get();
            var tokens = new List<TokenModel>();
            foreach (var item in data)
            {
                UserModel user = new UserModel()
                {
                    id=item.User.id,
                    dob=item.User.dob,
                    address=item.User.address,
                    email=item.User.email,
                    firstname=item.User.firstname,
                    organization_id=item.User.organization_id,
                    gender=item.User.gender,
                    lastname=item.User.lastname,
                    password=item.User.password,
                    phone=item.User.phone,
                    position=item.User.position,
                    type=item.User.type,
                    username=item.User.username,
                    user_status=item.User.user_status
                };
                tokens.Add(new TokenModel()
                {
                    id = item.id,
                    CreatedAt=item.CreatedAt,
                    ExpiredAt=item.ExpiredAt,
                    Token1=item.Token1,
                    User = user,
                    UserId=item.UserId

                });
            }
            return tokens;
        }
    }
}
