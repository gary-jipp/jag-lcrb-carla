// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.role
    /// </summary>
    public partial class MicrosoftDynamicsCRMrole
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMrole class.
        /// </summary>
        public MicrosoftDynamicsCRMrole()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMrole class.
        /// </summary>
        public MicrosoftDynamicsCRMrole(int? importsequencenumber = default(int?), string solutionid = default(string), string _roletemplateidValue = default(string), string _parentroleidValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _modifiedbyValue = default(string), string _modifiedonbehalfbyValue = default(string), string organizationid = default(string), string name = default(string), string canbedeleted = default(string), string _createdonbehalfbyValue = default(string), string _createdbyValue = default(string), string _businessunitidValue = default(string), string roleid = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), bool? ismanaged = default(bool?), int? componentstate = default(int?), string iscustomizable = default(string), string _parentrootroleidValue = default(string), string roleidunique = default(string), int? isinherited = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string versionnumber = default(string), IList<MicrosoftDynamicsCRMsystemuser> systemuserrolesAssociation = default(IList<MicrosoftDynamicsCRMsystemuser>), IList<MicrosoftDynamicsCRMprivilege> roleprivilegesAssociation = default(IList<MicrosoftDynamicsCRMprivilege>), IList<MicrosoftDynamicsCRMappmodule> appmodulerolesAssociation = default(IList<MicrosoftDynamicsCRMappmodule>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMrole parentroleid = default(MicrosoftDynamicsCRMrole), IList<MicrosoftDynamicsCRMrole> roleParentRole = default(IList<MicrosoftDynamicsCRMrole>), MicrosoftDynamicsCRMbusinessunit businessunitid = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMroletemplate roletemplateid = default(MicrosoftDynamicsCRMroletemplate), IList<MicrosoftDynamicsCRMasyncoperation> roleAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> roleBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMorganization organizationidOrganization = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMteam> teamrolesAssociation = default(IList<MicrosoftDynamicsCRMteam>), MicrosoftDynamicsCRMrole parentrootroleid = default(MicrosoftDynamicsCRMrole), IList<MicrosoftDynamicsCRMrole> roleParentRootRole = default(IList<MicrosoftDynamicsCRMrole>), IList<MicrosoftDynamicsCRMsyncerror> roleSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMsolution solutionRole = default(MicrosoftDynamicsCRMsolution), IList<MicrosoftDynamicsCRMmsdynActioncardrolesetting> msdynRoleMsdynActioncardrolesetting = default(IList<MicrosoftDynamicsCRMmsdynActioncardrolesetting>))
        {
            Importsequencenumber = importsequencenumber;
            Solutionid = solutionid;
            this._roletemplateidValue = _roletemplateidValue;
            this._parentroleidValue = _parentroleidValue;
            Modifiedon = modifiedon;
            this._modifiedbyValue = _modifiedbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Organizationid = organizationid;
            Name = name;
            Canbedeleted = canbedeleted;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._createdbyValue = _createdbyValue;
            this._businessunitidValue = _businessunitidValue;
            Roleid = roleid;
            Overwritetime = overwritetime;
            Ismanaged = ismanaged;
            Componentstate = componentstate;
            Iscustomizable = iscustomizable;
            this._parentrootroleidValue = _parentrootroleidValue;
            Roleidunique = roleidunique;
            Isinherited = isinherited;
            Overriddencreatedon = overriddencreatedon;
            Createdon = createdon;
            Versionnumber = versionnumber;
            SystemuserrolesAssociation = systemuserrolesAssociation;
            RoleprivilegesAssociation = roleprivilegesAssociation;
            AppmodulerolesAssociation = appmodulerolesAssociation;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Parentroleid = parentroleid;
            RoleParentRole = roleParentRole;
            Businessunitid = businessunitid;
            Roletemplateid = roletemplateid;
            RoleAsyncOperations = roleAsyncOperations;
            RoleBulkDeleteFailures = roleBulkDeleteFailures;
            OrganizationidOrganization = organizationidOrganization;
            Createdby = createdby;
            TeamrolesAssociation = teamrolesAssociation;
            Parentrootroleid = parentrootroleid;
            RoleParentRootRole = roleParentRootRole;
            RoleSyncErrors = roleSyncErrors;
            SolutionRole = solutionRole;
            MsdynRoleMsdynActioncardrolesetting = msdynRoleMsdynActioncardrolesetting;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_roletemplateid_value")]
        public string _roletemplateidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_parentroleid_value")]
        public string _parentroleidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public string Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "canbedeleted")]
        public string Canbedeleted { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_businessunitid_value")]
        public string _businessunitidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "roleid")]
        public string Roleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscustomizable")]
        public string Iscustomizable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_parentrootroleid_value")]
        public string _parentrootroleidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "roleidunique")]
        public string Roleidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isinherited")]
        public int? Isinherited { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "systemuserroles_association")]
        public IList<MicrosoftDynamicsCRMsystemuser> SystemuserrolesAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "roleprivileges_association")]
        public IList<MicrosoftDynamicsCRMprivilege> RoleprivilegesAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appmoduleroles_association")]
        public IList<MicrosoftDynamicsCRMappmodule> AppmodulerolesAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentroleid")]
        public MicrosoftDynamicsCRMrole Parentroleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "role_parent_role")]
        public IList<MicrosoftDynamicsCRMrole> RoleParentRole { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "businessunitid")]
        public MicrosoftDynamicsCRMbusinessunit Businessunitid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "roletemplateid")]
        public MicrosoftDynamicsCRMroletemplate Roletemplateid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Role_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> RoleAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Role_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> RoleBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid_organization")]
        public MicrosoftDynamicsCRMorganization OrganizationidOrganization { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "teamroles_association")]
        public IList<MicrosoftDynamicsCRMteam> TeamrolesAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentrootroleid")]
        public MicrosoftDynamicsCRMrole Parentrootroleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "role_parent_root_role")]
        public IList<MicrosoftDynamicsCRMrole> RoleParentRootRole { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Role_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> RoleSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solution_role")]
        public MicrosoftDynamicsCRMsolution SolutionRole { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_role_msdyn_actioncardrolesetting")]
        public IList<MicrosoftDynamicsCRMmsdynActioncardrolesetting> MsdynRoleMsdynActioncardrolesetting { get; set; }

    }
}
