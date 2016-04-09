﻿using AutoMapper;
using YZMIS.Objects;
using System.Collections.Generic;

namespace YZMIS.Data.Mapping
{
    public class ObjectMapper
    {
        public static void MapObjects()
        {
            Mapper.Initialize(configuration => new ObjectMapper(configuration).Map());
        }

        private IMapperConfiguration Configuration { get; set; }

        private ObjectMapper(IMapperConfiguration configuration)
        {
            Configuration = configuration;
        }

        private void Map()
        {
            MapRoles();
            MapAccounts();
        }

        #region Administration

        private void MapRoles()
        {
            Configuration.CreateMap<Role, RoleView>()
                .ForMember(role => role.Permissions, member => member.Ignore());
            Configuration.CreateMap<RoleView, Role>()
                .ForMember(role => role.Permissions, member => member.UseValue(new List<RolePermission>()));
        }
        private void MapAccounts()
        {
            Configuration.CreateMap<Account, AccountView>();
            Configuration.CreateMap<Account, AccountEditView>();
            Configuration.CreateMap<Account, ProfileEditView>();

            Configuration.CreateMap<AccountCreateView, Account>();
            Configuration.CreateMap<AccountRegisterView, Account>();
        }

        #endregion
    }
}
