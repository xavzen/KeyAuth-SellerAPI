using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using xavHub;

namespace KeyAuthSeller
{
    public class SellerApi
    {
        #region SellerAPI
        private string _sellerKey;

        /// <summary>
        /// Set your application seller key in order to use keyAuth admin, can be blank as long as you call SetSellerKey
        /// </summary>
        /// <param name="sellerKey">Application seller key, can be found under seller settings of dashboard.</param>
        public SellerApi(string sellerKey)
        {
            InitClient();
            string url = $"?sellerkey={sellerKey}&type=setseller";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            if(json.Success)
                _sellerKey = sellerKey;
            else
                _sellerKey = null;
            LoadResponseStruct(json);
        }

        /// <summary>
        /// You must call SetSellerKey() if you use this
        /// </summary>
        public SellerApi()
        {
            InitClient();
        }
        /// <summary>
        /// Set your seller key allows you to change the seller key on the fly
        /// </summary>
        /// 
        public void SetSellerKey(string sellerKey)
        {
            string url = $"?sellerkey={sellerKey}&type=setseller";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            if (json.Success)
                
                _sellerKey = sellerKey;
            else
                _sellerKey = null;
            LoadResponseStruct(json);
        }
        #endregion

        #region Response_Structure
        private class ResponseStructure
        {
            [JsonPropertyName("success")]
            public bool Success { get; set; }

            [JsonPropertyName("message")]
            public string Message { get; set; }
        }

        #endregion

        #region VariablesStructure
        private class VariablesStructure
        {
            public string List { get; set; }
            public int Total { get; set; }
            [JsonPropertyName("vars")]
            public List<Vars> Vars { get; set; }
        }
        public class Vars
        {
            [JsonPropertyName("varid")]
            public string Varid { get; set; }

            [JsonPropertyName("msg")]
            public string Msg { get; set; }
        }
        #endregion

        #region BlacksStructure

        private class BlacksStructure
        {
            public string List { get; set; }
            public int Total { get; set; }
            [JsonPropertyName("subs")]
            public List<BlackSub> Subs { get; set; }
        }
        public class BlackSub
        {
            [JsonPropertyName("hwid")]
            public string Hwid { get; set; }

            [JsonPropertyName("ip")]
            public string Ip { get; set; }

            [JsonPropertyName("type")]
            public string Type { get; set; }
        }
        #endregion

        #region SettingsStructure

        private class SettingsStructure
        {
            public string List { get; set; }

            [JsonPropertyName("enabled")]
            public bool Enabled { get; set; }

            [JsonPropertyName("hwid-lock")]
            public bool HwidLock { get; set; }

            [JsonPropertyName("version")]
            public string Version { get; set; }

            [JsonPropertyName("webhook")]
            public string Webhook { get; set; }

            [JsonPropertyName("resellerstore")]
            public string Resellerstore { get; set; }

            [JsonPropertyName("disabledmsg")]
            public string Disabledmsg { get; set; }

            [JsonPropertyName("usernametakenmsg")]
            public string Usernametakenmsg { get; set; }

            [JsonPropertyName("licenseinvalidmsg")]
            public string Licenseinvalidmsg { get; set; }

            [JsonPropertyName("keytakenmsg")]
            public string Keytakenmsg { get; set; }

            [JsonPropertyName("nosubmsg")]
            public string Nosubmsg { get; set; }

            [JsonPropertyName("userinvalidmsg")]
            public string Userinvalidmsg { get; set; }

            [JsonPropertyName("passinvalidmsg")]
            public string Passinvalidmsg { get; set; }

            [JsonPropertyName("hwidmismatchmsg")]
            public string Hwidmismatchmsg { get; set; }

            [JsonPropertyName("noactivesubmsg")]
            public string Noactivesubmsg { get; set; }

            [JsonPropertyName("blackedmsg")]
            public string Blackedmsg { get; set; }

            [JsonPropertyName("expiredmsg")]
            public string Expiredmsg { get; set; }

            [JsonPropertyName("sellixsecret")]
            public string Sellixsecret { get; set; }
        }

        #endregion

        #region FilesStructure
        private class FilesStructure
        {
            public string List { get; set; }
            public int Total { get; set; }
            [JsonPropertyName("files")]
            public List<Docs> Files { get; set; }
        }
        public class Docs
        {
            [JsonPropertyName("id")]
            public string Id { get; set; }

            [JsonPropertyName("url")]
            public string Url { get; set; }
        }
        #endregion

        #region SubsStructure
        private class SubsStructure
        {
            public string List { get; set; }
            public int Total { get; set; }
            [JsonPropertyName("subs")]
            public List<Sub> Subs { get; set; }
        }
        public class Sub
        {
            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("level")]
            public string Level { get; set; }
        }
        #endregion

        #region UsersStructure
        private class UsersStructure
        {
            public int Total { get; set; }
            public string List { get; set; }
            [JsonPropertyName("response")]
            public string Response { get; set; }
            [JsonPropertyName("users")]
            public List<User> Users { get; set; }
            [JsonPropertyName("vars")]
            public List<Var> Vars { get; set; }
            [JsonPropertyName("username")]
            public string Username { get; set; }
            [JsonPropertyName("subscriptions")]
            public List<UserSubs> Subscriptions { get; set; }

            [JsonPropertyName("ip")]
            public string Ip { get; set; }

            [JsonPropertyName("hwid")]
            public string Hwid { get; set; }

            [JsonPropertyName("createdate")]
            public string Createdate { get; set; }

            [JsonPropertyName("lastlogin")]
            public string Lastlogin { get; set; }
            [JsonPropertyName("usernames")]
            public List<string> Usernames { get; set; }

        }
        public class UserSubs
        {
            public string Subscription { get; set; }
            public string Expiry { get; set; }
            public string Timeleft { get; set; }
        }
        public class Var
        {
            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("data")]
            public string Data { get; set; }

            [JsonPropertyName("user")]
            public string User { get; set; }
        }
        public class User
        {
            [JsonPropertyName("username")]
            public string Username { get; set; }

            [JsonPropertyName("password")]
            public string Password { get; set; }

            [JsonPropertyName("hwid")]
            public string Hwid { get; set; }

            [JsonPropertyName("app")]
            public string App { get; set; }

            [JsonPropertyName("owner")]
            public string Owner { get; set; }

            [JsonPropertyName("createdate")]
            public string Createdate { get; set; }

            [JsonPropertyName("lastlogin")]
            public string Lastlogin { get; set; }

            [JsonPropertyName("banned")]
            public string Banned { get; set; }

            [JsonPropertyName("ip")]
            public string Ip { get; set; }

            [JsonPropertyName("cooldown")]
            public object Cooldown { get; set; }
        }
        #endregion

        #region LicenseStructure
        private class KeysStructure
        {
            public string List { get; set; }
            [JsonPropertyName("keys")]
            public List<string> Keys { get; set; }
            [JsonPropertyName("key")]
            public string Key { get; set; }
        }
        private class LicenseStructure
        {
            public int Total { get; set; }
            public string List { get; set; }
            [JsonPropertyName("info")]
            public Info Info { get; set; }
            [JsonPropertyName("keys")]
            public List<Keys> Keys { get; set; }

            public string Key { get; set; }
        }
        public class Keys
        {
            [JsonPropertyName("id")]
            public string Id { get; set; }

            [JsonPropertyName("key")]
            public string Key { get; set; }

            [JsonPropertyName("note")]
            public object Note { get; set; }

            [JsonPropertyName("expires")]
            public string Expires { get; set; }

            [JsonPropertyName("status")]
            public string Status { get; set; }

            [JsonPropertyName("level")]
            public string Level { get; set; }

            [JsonPropertyName("genby")]
            public string Genby { get; set; }

            [JsonPropertyName("gendate")]
            public string Gendate { get; set; }

            [JsonPropertyName("usedon")]
            public string Usedon { get; set; }

            [JsonPropertyName("usedby")]
            public string Usedby { get; set; }

            [JsonPropertyName("app")]
            public string App { get; set; }

            [JsonPropertyName("banned")]
            public object Banned { get; set; }
        }
        public class Subs
        {
            [JsonPropertyName("subscription")]
            public string Subscription { get; set; }

            [JsonPropertyName("expiry")]
            public string Expiry { get; set; }

            [JsonPropertyName("timeleft")]
            public int Timeleft { get; set; }

            [JsonPropertyName("username")]
            public string Username { get; set; }

            [JsonPropertyName("subscriptions")]
            public List<Subs> Subscriptions { get; set; }

            [JsonPropertyName("ip")]
            public string Ip { get; set; }

            [JsonPropertyName("hwid")]
            public object Hwid { get; set; }

            [JsonPropertyName("createdate")]
            public string Createdate { get; set; }

            [JsonPropertyName("lastlogin")]
            public string Lastlogin { get; set; }
        }
        public class Info
        {
            [JsonPropertyName("username")]
            public string Username { get; set; }

            [JsonPropertyName("subscriptions")]
            public Subs Subscriptions { get; set; }

            [JsonPropertyName("ip")]
            public string Ip { get; set; }
        }
        #endregion


        private class AppStatsStructure
        {
            [JsonPropertyName("unused")]
            public string Unused { get; set; }

            [JsonPropertyName("used")]
            public string Used { get; set; }

            [JsonPropertyName("paused")]
            public string Paused { get; set; }

            [JsonPropertyName("banned")]
            public string Banned { get; set; }

            [JsonPropertyName("totalkeys")]
            public string Totalkeys { get; set; }

            [JsonPropertyName("webhooks")]
            public string Webhooks { get; set; }

            [JsonPropertyName("files")]
            public string Files { get; set; }

            [JsonPropertyName("vars")]
            public string Vars { get; set; }

            [JsonPropertyName("resellers")]
            public string Resellers { get; set; }

            [JsonPropertyName("managers")]
            public string Managers { get; set; }

            [JsonPropertyName("totalaccs")]
            public string Totalaccs { get; set; }
        }
 
        #region Licenses

        /// <summary>
        ///  Creates a new license, Expiry  int in days from now Day(0) Week(1) Month(2) Year(3) Lifetime(4)10 years from now
        /// </summary>
        /// <param name="expiry">Expiry  int in days from now Day(0) Week(1) Month(2) Year(3) Lifetime(4)10 years from now</param>
        /// <param name="mask">If not set, defaults to "XXXXXX-XXXXXX-XXXXXX-XXXXXX-XXXXXX-XXXXXX"</param>
        /// <param name="level">If not set, defaults to 1.</param>
        /// <param name="amount">If not set, defaults to 1.</param>
        public void LicenseGen(int expiry,string mask, int level, int amount)
        {
            int days = 0;
            if (expiry == 0)
                days = 1;
            else if (expiry == 1)
                days = 7;
            else if (expiry == 2)
                days = 30;
            else if (expiry == 3)
                days = 365;
            else if (expiry == 4)
                days = 3650;
            string url = $"?sellerkey={_sellerKey}&type=add&expiry={days}&mask={mask}&level={level}&amount={amount}";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            if (json.Success)
            {
                int number = 1;
                string list = string.Empty;
                var jsonKeys = JsonConvert.DeserializeObject<KeysStructure>(response);
                if (amount > 1)
                {
                    foreach (var var in jsonKeys.Keys)
                        list += $"License {number++}: {var}" + "\n";
                    jsonKeys.List = list;
                }
                
                LoadKeysStruct(jsonKeys);
            }
            LoadResponseStruct(json);
        }

        /// <summary>
        ///  Varifies a license exists
        /// </summary>
        /// <param name="key">The key you would like to check exists</param>
        public void LicenseVerify(string license)
        {
            string url = $"?sellerkey={_sellerKey}&type=verify&key={license}";
            string response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
        }
        /// <summary>
        ///  Creates a user from a license key with password
        /// </summary>
        /// <param name="userName">The user name you would like to give the new user</param
        public void LicenseCreateUser(string userName,string license, string passWord)
        {
            string urlCreate = $"?sellerkey={_sellerKey}&type=activate&user={userName}&key={license}&pass={passWord}";
            string urlReset = $"?sellerkey={_sellerKey}&type=resetpw&user={userName}";
            var jsonCreate = JsonConvert.DeserializeObject<ResponseStructure>(Request(urlCreate));
            LoadResponseStruct(jsonCreate);
            if (jsonCreate.Success)
                if(passWord == "")
                {
                    var jsonReset = JsonConvert.DeserializeObject<ResponseStructure>(Request(urlReset));
                    if (jsonReset.Success)
                    {
                        jsonReset.Message = "Successfuly Created new user from license, Have the user sign in to set a password.";
                        LoadResponseStruct(jsonReset);
                    }
                    else
                        LoadResponseStruct(jsonReset);
                }
                else
                {

                    jsonCreate.Message = "Successfuly Created new user from license.";
                    LoadResponseStruct(jsonCreate);
                }
        }

        /// <summary>
        ///  Delete a license
        /// </summary>
        /// <param name="key">The key you would like to delete</param>
        public void LicenseDelete(string license)
        {
            string url = $"?sellerkey={_sellerKey}&type=del&key={license}";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
        }

        /// <summary>
        ///  Delete unused license keys
        /// </summary>
        public void LicenseDeleteUnused()
        {
            string url = $"?sellerkey={_sellerKey}&type=delunused";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
        }

        /// <summary>
        ///  Delete used license keys
        /// </summary>
        public void LicenseDeleteUsed()
        {
            string url = $"?sellerkey={_sellerKey}&type=delused";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
        }

        /// <summary>
        ///  Delete all license keys
        /// </summary>
        public void LicenseDeleteAll()
        {
            string url = $"?sellerkey={_sellerKey}&type=delalllicenses";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
        }

        /// <summary>
        ///  Fetch all license keys
        /// </summary>
        public void LicenseViewAll()
        {
            string url = $"?sellerkey={_sellerKey}&type=fetchallkeys";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            if(json.Success)
            {
                var jsonLicense = JsonConvert.DeserializeObject<LicenseStructure>(response);
                string list = string.Empty;
                int number = 1;
                foreach(var license in jsonLicense.Keys)
                    list += $"License {number++}: ID = {license.Id} | Key = {license.Key} | Note = {license.Note} | Expires = {license.Expires} | Status = {license.Status} | Level = {license.Level} | Gened By = {license.Genby} | Gen Date = {license.Gendate} | Used On = {license.Usedon} | App = {license.App} | Banned = {license.Banned}"+"\n";
                jsonLicense.List = list; 
                jsonLicense.Total = jsonLicense.Keys.Count;
                LoadLicenseStruct(jsonLicense);
            }
            LoadResponseStruct(json);
        }

        /// <summary>
        ///  Add time to unused licneses, Set the time in days from now Day(0) Week(1) Month(2) Year(3) Lifetime(4)10 years from now
        /// </summary>
        ///  /// <param name="time">Set the time in days from now Day(0) Week(1) Month(2) Year(3) Lifetime(4)10 years from now </param>
        public void LicenseAddTime(int time)
        {
            int days = 0;
            if (time == 0)
                days = 1;
            else if (time == 1)
                days = 7;
            else if (time == 2)
                days = 30;
            else if (time == 3)
                days = 365;
            else if (time == 4)
                days = 3650;
            string url = $"?sellerkey={_sellerKey}&type=addtime&time={days}";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
        }

        /// <summary>
        ///  Unban a user that was banned
        /// </summary>
        /// <param name="license">The license key to unban</param>
        public void LicenseUnban(string license)
        {
            string url = $"?sellerkey={_sellerKey}&type=unban&key={license}";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
        }

        /// <summary>
        ///  Ban a use
        /// </summary>
        /// <param name="license">The license key to unban</param>
        /// <param name="banReason">The license key to unban</param>
        public void LicenseBan(string license, string banReason)
        {
            string url = $"?sellerkey={_sellerKey}&type=ban&key={license}&reason={banReason}";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
        }   
        /// <summary>
        ///  Retrieve license from user
        /// </summary>
        ///  /// <param name="userName">The user to get key from</param>
        public void ViewUserLicense(string userName)
        {
            string url = $"?sellerkey={_sellerKey}&type=getkey&user={userName}";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            if (json.Success)
            {
                var jsonSecond = JsonConvert.DeserializeObject<LicenseStructure>(response);
                json.Message = "Successfully retrieved license";
                LoadLicenseStruct(jsonSecond);
            }
            else
                json.Message = "License not found, are you sure the username is correct";
            LoadResponseStruct(json);
        }
        #endregion

        #region Users

        public void AppStats()
        {
            string url = $"?sellerkey={_sellerKey}&type=stats";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
            if (json.Success)
            {
                var jsonStats = JsonConvert.DeserializeObject<AppStatsStructure>(response);
                LoadAppStatsStruct(jsonStats);
            }
        }

        /// <summary>
        ///  Creates a new user, Expiry  int in days from now Day(0) Week(1) Month(2) Year(3) Lifetime(4)10 years from now
        /// </summary>
        /// <param name="userName">The username you would like to set</param>
        /// <param name="subName">The sub level to give the new user</param>
        /// <param name="expiry">Set the expiry in days from now Day(0) Week(1) Month(2) Year(3) Lifetime(4)10 years from now </param>
        /// <param name="userPass">The password to set to the new user</param>
        public void UserCreate(string userName, string subName, int expiry, string userPass)
        {
            
            int days = 0;
            if (expiry == 0)
                days = 1;
            else if(expiry == 1)
                days = 7;
            else if (expiry == 2)
                days = 30;
            else if (expiry == 3)
                days = 365;
            else if (expiry == 4)
                days = 3650;
            string url = $"?sellerkey={_sellerKey}&type=adduser&user={userName}&sub={subName}&expiry={days}&pass={userPass}";
            if (userPass == null)
                url = $"?sellerkey={_sellerKey}&type=adduser&user={userName}&sub={subName}&expiry={days}";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
        }

        /// <summary>
        ///  Deletes the seleted user
        /// </summary>
        /// <param name="userName">The user you would like to delete</param>
        public void UserDelete(string userName)
        {
            string url = $"?sellerkey={_sellerKey}&type=deluser&user={userName}";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
        }

        /// <summary>
        ///  Delete expired users
        /// </summary>
        public void UserDeleteExpired()
        {
            string url = $"?sellerkey={_sellerKey}&type=delexpusers";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
        }

        /// <summary>
        ///  Reset a users HWID
        /// </summary>
        /// <param name="userName">The username of the user you would like to reset</param>
        public void UserHwidReset(string userName)
        {
            string url = $"?sellerkey={_sellerKey}&type=resetuser&user={userName}";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
        }

        /// <summary>
        ///  Set a users variable, It can be set to (all)
        /// </summary>
        /// <param name="userName">The User(s) you're assigning the variable. It can be (all)</param>
        /// <param name="data">Data of user variable you're updating or creating</param>
        /// <param name="varName">Name of user variable you want to create or update</param>
        public void UserSetVar(string userName,string varName, string data)
        {
            string url = $"?sellerkey={_sellerKey}&type=setvar&user={userName}&var={varName}&data={data}";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
        }

        /// <summary>
        ///  Get a users variable
        /// </summary>
        /// <param name="userName">The Username you're trying to get the variable from</param>
        /// <param name="varName">The variable name to get the value from</param>
        public void UserVar(string userName, string varName)
        {
            string url = $"?sellerkey={_sellerKey}&type=getvar&user={userName}&var={varName}";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
            if (json.Success)
            {
                var jsonSecond = JsonConvert.DeserializeObject<UsersStructure>(response);
                LoadUsersStruct(jsonSecond);
            }
                
        }

        /// <summary>
        ///  Ban a user
        /// </summary>
        /// <param name="userName">The User you're trying to ban</param>
        /// <param name="banReason">The reason for banning the user</param>
        public void UserBan(string userName, string banReason)
        {
            string url = $"?sellerkey={_sellerKey}&type=banuser&user={userName}&reason={banReason}";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
        }

        /// <summary>
        ///  Unban a user
        /// </summary>
        /// <param name="userName">The User you're trying to unban</param>
        public void UserUnban(string userName)
        {
            string url = $"?sellerkey={_sellerKey}&type=unbanuser&user={userName}";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
        }

        /// <summary>
        ///  Delete a users variable
        /// </summary>
        /// <param name="userName">The User you're deleting the variable for</param>
        /// <param name="varName">The variable name you're deleting</param>
        public void UserDeleteVar(string userName, string varName)
        {
            string url = $"?sellerkey={_sellerKey}&type=deluservar&user={userName}&var={varName}";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
        }

        /// <summary>
        ///  Delete a users sub level
        /// </summary>
        /// <param name="userName">The User you're deleting the sub for</param>
        /// <param name="subName">The sub name your deleting</param>
        public void UserDeleteSub(string userName, string subName)
        {
            string url = $"?sellerkey={_sellerKey}&type=delsub&user={userName}&sub={subName}";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
        }

        /// <summary>
        ///  Extends a users time, usere can be set to (all), Set the int in days from now Day(0) Week(1) Month(2) Year(3) Lifetime(4)10 years from now 
        /// </summary>
        /// <param name="userName">The User you're extending time</param>
        /// <param name="subName">The name of the sub your adding</param>
        /// <param name="expiry">Set the int in days from now Day(0) Week(1) Month(2) Year(3) Lifetime(4)10 years from now </param>
        public void UserExtendSub(string userName, string subName, int expiry)
        {
            int days = 0;
            if (expiry == 0)
                days = 1;
            else if (expiry == 1)
                days = 7;
            else if (expiry == 2)
                days = 30;
            else if (expiry == 3)
                days = 365;
            else if (expiry == 4)
                days = 3650;
            string url = $"?sellerkey={_sellerKey}&type=extend&user={userName}&sub={subName}&expiry={days}";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
        }

        /// <summary>
        ///  Delect all users
        /// </summary>
        public void UserDeleteAll()
        {
            string url = $"?sellerkey={_sellerKey}&type=delallusers";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
        }

        /// <summary>
        ///  Reset all users HWID
        /// </summary>
        public void UserHwidResetAll()
        {
            string url = $"?sellerkey={_sellerKey}&type=resetalluser";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
        }

        /// <summary>
        ///  Verify a user from a username
        /// </summary>
        /// <param name="userName">The username you would like to verify</param>
        public void VerifyUser(string userName)
        {
            string url = $"?sellerkey={_sellerKey}&type=verifyuser&user={userName}";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
        }

        /// <summary>
        ///  Add a HWID to a user
        /// </summary>
        /// <param name="userName">The username you would like to add the HWID to</param>
        /// <param name="hwid">The HWID number you would like to assign</param>
        public void UserHwidAdd(string userName, string hwid)
        {
            string url = $"?sellerkey={_sellerKey}&type=addhwiduser&user={userName}&hwid={hwid}";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
        }

        /// <summary>
        ///  Get all users
        /// </summary>
        public void UserViewAll()
        {
            string url = $"?sellerkey={_sellerKey}&type=fetchallusers";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
            if(json.Success)
            {
                var jsonUsers = JsonConvert.DeserializeObject<UsersStructure>(response);
                jsonUsers.Total = jsonUsers.Users.Count;
                LoadUsersStruct(jsonUsers);
            }
        }

        /// <summary>
        ///  Change a users password
        /// </summary>
        /// <param name="userName">The user you would like change password for</param>
        /// <param name="passWord">The password you would like change to</param>
        public void UserChangePass(string userName, string passWord)
        {
            string url = $"?sellerkey={_sellerKey}&type=resetpw&user{userName}&passwd={passWord}";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
        }

        /// <summary>
        ///  Reset a users password
        /// </summary>
        /// <param name="userName">The user you would like change password for</param>
        public void UserResetPass(string userName)
        {
            string url = $"?sellerkey={_sellerKey}&type=resetpw&user={userName}";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            if (json.Success)
                json.Message = "User's password was successly reset, have them sign in to set a new password";
            else
                json.Message = "Failed this user's password was already reset";
            LoadResponseStruct(json);
        }

        /// <summary>
        ///  Get all user variables
        /// </summary>
        public void UserViewVars()
        {
            string url = $"?sellerkey={_sellerKey}&type=fetchalluservars";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
            if (json.Success)
            {
                var jsonUserVar = JsonConvert.DeserializeObject<UsersStructure>(response);
                string final = string.Empty;
                int number = 1;
                foreach (var userVar in jsonUserVar.Vars)
                    final += $"User Var {number++}: Name = {userVar.Name} | Data = {userVar.Data} | User = {userVar.User}"+"\n";
                jsonUserVar.List = final;
                jsonUserVar.Total = jsonUserVar.Vars.Count;
                LoadUsersStruct(jsonUserVar);
            }
        }

        /// <summary>
        ///  Get all user data
        /// </summary>
        /// <param name="userName">The user you would like the data for</param>
        public void ViewUserData(string userName)
        {
            string url = $"?sellerkey={_sellerKey}&type=userdata&user={userName}";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            if (json.Success)
            {
                var jsonData = JsonConvert.DeserializeObject<UsersStructure>(response);
                int number = 1;
                string list = string.Empty;
                if (jsonData.Lastlogin == null)
                    jsonData.Lastlogin = jsonData.Createdate;
                list += $"User: {jsonData.Username}\n";
                foreach (var data in jsonData.Subscriptions)
                    list += $"Sub {number++}: Name = {data.Subscription} | Expiry = {UnixTimeToDateTime(long.Parse(data.Expiry))} | TimeLeft = {data.Timeleft} "+"\n";
                list += $"IP: {jsonData.Ip}" +
                    $"\nHWID: {jsonData.Hwid}" +
                    $"\nCreation Date: {UnixTimeToDateTime(long.Parse(jsonData.Createdate))}" +
                    $"\nLast Login: {UnixTimeToDateTime(long.Parse(jsonData.Lastlogin))}";
                jsonData.List = list;
                LoadUsersStruct(jsonData);
                json.Message = "User details successfully received";
            }
            LoadResponseStruct(json);

        }

        public void UserAllUserNames()
        {
            string url = $"?sellerkey={_sellerKey}&type=fetchallusernames";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            if (json.Success)
            {
                var jsonUsers = JsonConvert.DeserializeObject<UsersStructure>(response);
                string list = string.Empty;
                int number = 1;
                foreach (var users in jsonUsers.Usernames)
                    list += $"User {number++}: {users}\n";
                jsonUsers.List = list;
                jsonUsers.Total = jsonUsers.Usernames.Count;
                LoadUsersStruct(jsonUsers);
            }
            LoadResponseStruct(json);
        }

        #endregion

        #region Subscriptions
        /// <summary>
        ///  Creates a subscription
        /// </summary>
        /// <param name="subName">The name of the new sub your creating</param>
        /// <param name="subLevel">The level of the sub</param>
        public void SubCreate(string subName, int subLevel)
        {
            string url = $"?sellerkey={_sellerKey}&type=addsub&name={subName}&level={subLevel}";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
        }
        /// <summary>
        ///  Deletes a subscription
        /// </summary>
        /// <param name="subName">The name of the sub your would like to delete</param>
        public void SubDelete(string subName)
        {
            string url = $"?sellerkey={_sellerKey}&type=delappsub&name={subName}";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
        }
        ///////////
        /// <summary>
        ///  Gets all subscriptions
        /// </summary>
        public void SubViewAll()
        {
            string url = $"?sellerkey={_sellerKey}&type=fetchallsubs";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            if(json.Success)
            {
                string list = string.Empty;
                int number = 1;
                var jsonSubs = JsonConvert.DeserializeObject<SubsStructure>(response);
                foreach (var sub in jsonSubs.Subs)
                    list += $"Sub {number++}: Name = {sub.Name} | Level = {sub.Level}" + "\n";
                jsonSubs.List = list;
                jsonSubs.Total = jsonSubs.Subs.Count;
                LoadSubStruct(jsonSubs);
            }
            LoadResponseStruct(json);
        }
        /////////////////
        public void SubEdit(string subName, int subLevel)
        {
            string url = $"?sellerkey={_sellerKey}&type=editsub&sub={subName}&level={subLevel}";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
        }


        #endregion

        #region Chats
        /// <summary>
        ///  Creates a chat channel on keyAuth
        /// </summary>
        /// <param name="channelName">The name of the channel you would like to create</param>
        /// <param name="timeOut">the channel talk delay in seconds</param>
        public void ChatCreateChannel(string channelName, int timeOut)
        {
            string seconds = timeOut.ToString();
            string url = $"?sellerkey={_sellerKey}&type=addchannel&name={channelName}&delay={seconds}";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
        }
        /// <summary>
        ///  Deletes the named chat channel on keyAuth
        /// </summary>
        /// <param name="channelName">The name of the channel you would like to delete</param>
        public void ChatDeleteChannel(string channelName)
        {
            string url = $"?sellerkey={_sellerKey}&type=delchannel&name={channelName}";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
        }
        /// <summary>
        ///  Clears the named chat channel on keyAuth
        /// </summary>
        /// <param name="channelName">The name of the channel you would like to delete</param>
        public void ChatClearChannel(string channelName)
        {
            string url = $"?sellerkey={_sellerKey}&type=clearchannel&name={channelName}";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
        }
        /// <summary>
        ///  Mutes user by username on KeyAuth
        /// </summary>
        /// <param name="userName">The username of the person you would like to mute</param>
        /// <param name="timeOut">The user timeout in seconds</param>
        public void ChatMuteUser(string userName, int timeOut)
        {
            string seconds = timeOut.ToString();
            string url = $"?sellerkey={_sellerKey}&type=muteuser&user={userName}&time={seconds}";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
        }
        /// <summary>
        ///  Unmutes user by username on KeyAuth
        /// </summary>
        /// <param name="userName">The name of the channel you would like to delete</param>
        public void ChatUnmuteUser(string userName)
        {
            string url = $"?sellerkey={_sellerKey}&type=unmuteuser&user={userName}";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
        }

        #endregion

        #region Sessions
        /// <summary>
        ///  Kills session by session id number
        /// </summary>
        /// <param name="sessionId">The session id number you would like to kill</param>
        public void SessionKill(string sessionId)
        {
            string url = $"?sellerkey={_sellerKey}&type=kill&sessid={sessionId}";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
        }
        /// <summary>
        /// Kills all active sessions
        /// </summary>
        public void SessionKillAll()
        {
            string url = $"?sellerkey={_sellerKey}&type=killall";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
        }
        #endregion

        #region Webhooks
        /// <summary>
        /// Creates a webhook
        /// </summary>
        /// <param name="link">The URL link for your webhook</param>
        /// <param name="authed">bool authed(true) or not(false)</param>
        public void CreateWebHook(string link, bool authed)
        {
            int needAuthed = 0;
            if (authed)
                needAuthed = 1;
            else if (!authed)
                needAuthed = 0;
            string url = $"?sellerkey={_sellerKey}&type=addwebhook&baseurl={link}&ua=&authed={needAuthed}";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
        }
        #endregion

        #region Files
        /// <summary>
        /// Uploads a file used to download files in a more secure manner via KeyAuth
        /// </summary>
        /// <param name="file">The URL link to your file</param>
        public void FileUpload(string file)
        {
            string url = $"?sellerkey={_sellerKey}&type=upload&url={file}";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
        }
        /// <summary>
        /// Deletes file stored on KeyAuth
        /// </summary>
        /// <param name="fileId">The file id number(int) you would like to delete</param>
        public void FileDelete(int fileId)
        {
            string file = fileId.ToString();
            string url = $"?sellerkey={_sellerKey}&type=delfile&fileid={file}";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            if (json.Success)
                json.Message = $"Successfully deleted file! (File ID = {file})";
            else
                json.Message = $"Failed to delete file! (File ID = {file})";
            LoadResponseStruct(json);
        }
        /// <summary>
        /// Deletes all files stored on KeyAuth
        /// </summary>
        public void FileDeleteAll()
        {
            string url = $"?sellerkey={_sellerKey}&type=delallfiles";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            if (!json.Success)
                json.Message = $"Failed you have no files to delete!";
            LoadResponseStruct(json);
        }
        /// <summary>
        /// Gets all files stored on KeyAuth
        /// </summary>
        public void FileViewAll()
        {
            string url = $"?sellerkey={_sellerKey}&type=fetchallfiles";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            if (json.Success)
            {
                string list = string.Empty;
                var jsonFiles = JsonConvert.DeserializeObject<FilesStructure>(response);
                int number = 1;
                foreach (var Var in jsonFiles.Files)
                    list += $"File {number++}: ID = {Var.Id} | URL = {Var.Url}" + "\n";
                jsonFiles.List = list;
                jsonFiles.Total = jsonFiles.Files.Count;
                LoadFileStruct(jsonFiles);
            }
            LoadResponseStruct(json);
        }
        /// <summary>
        /// Downloads selected file from KeyAuth
        /// </summary>
        /// <param name="fileId">The file id number you wish to download</param>
        /// <param name="fileName">The name of the file once downloaded</param>
        /// <param name="path">The path to download the file to</param>
        public string FileDownload(string url , string filePath , bool start, bool runAsAdmin)
        {
            var req = Client.GetAsync(url).ContinueWith(res =>
            {
                var result = res.Result;
                if (result.StatusCode == (HttpStatusCode)200)
                {
                    var readData = result.Content.ReadAsByteArrayAsync();
                    readData.Wait();
                    var readstream = readData.Result;
                    File.WriteAllBytes(filePath, readstream);
                    return null;
                }
                else
                    return "Failed to download file!";
            });
            req.Wait();
            if (start == true)
            {
                if (runAsAdmin == true)
                    ExecuteAsAdmin(filePath);
                else
                    Process.Start(filePath);
            }
            return "Successfully downloaded file.";
        }
        #endregion

        #region Variables
        /// <summary>
        /// Adds a Variable to your Variables.
        /// </summary>
        /// <param name="varName">Desired Variable Name</param>
        /// <param name="varData">Data Associated with variable</param>
        /// <param name="authed">Determines whether user needs to be logged in (true) or not (false)/param>
        public void VariableCreate(string varName, string varData, bool authed)
        {
            int needAuthed = 0;
            if(authed)
                needAuthed = 1;
            else if(!authed)
                needAuthed = 0;
            string url = $"?sellerkey={_sellerKey}&type=addvar&name={varName}&data={varData}&authed={needAuthed}";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
        }
        /// <summary>
        /// Edits a Variable thats on your Variables list.
        /// </summary>
        /// <param name="varName">Variable name to edit </param>
        /// <param name="varData">Variable data to change</param>
        public void VariableEdit(string varName, string varData)
        {
            string url = $"?sellerkey={_sellerKey}&type=editvar&varid={varName}&data={varData}";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
        }
        /// <summary>
        /// Gets a Variable by name thats on your Variables list.
        /// </summary>
        /// <param name="varName">Name of variable to get data from</param>
        public void VariableGet(string varName)
        {
            string url = $"?sellerkey={_sellerKey}&type=retrvvar&name={varName}";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
        }
        /// <summary>
        /// Gets all Variables that are on your Variables list.
        /// </summary>
        public void VariableViewAll()
        {
            string url = $"?sellerkey={_sellerKey}&type=fetchallvars";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            if (json.Success)
            {
                string list = string.Empty;
                int number = 1;
                var jsonVars = JsonConvert.DeserializeObject<VariablesStructure>(response);
                foreach (var var in jsonVars.Vars)
                    list += $"Variable {number++}: Var ID = {var.Varid} | Var Msg = {var.Msg}" + "\n";
                jsonVars.List = list;
                jsonVars.Total = jsonVars.Vars.Count;
                LoadVariablesStruct(jsonVars);
            }
            LoadResponseStruct(json);
        }
        /// <summary>
        /// Delete a variable by name thats on your Variables list.
        /// </summary>
        /// <param name="varName">The variable to delete</param>
        public void VariableDelete(string varName)
        {
            string url = $"?sellerkey={_sellerKey}&type=delvar&name={varName}";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
        }
        /// <summary>
        /// Deletes all variables that are on your Variables list.
        /// </summary>
        public void VariableDeleteAll()
        {
            string url = $"?sellerkey={_sellerKey}&type=delallvars";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
        }
        #endregion

        #region Blacklists
        /// <summary>
        /// Adds a black to your black lists.
        /// </summary>
        /// <remarks>IP If left blank, the IP address the request came from will be blacklisted. | HWID if left blank, none will be blacklisted.</remarks>
        /// <param name="hwid">HWID you'd like to blacklist. If left blank, none will be blacklisted.</param>
        /// <param name="ip">IP address you'd like to blacklist. If left blank, the IP address the request came from will be blacklisted.</param>
        public void BlackAdd(string ip, string hwid)
        {
            string url = $"?sellerkey={_sellerKey}&type=black&ip={ip}&hwid={hwid}";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
        }
        /// <summary>
        /// Deletes a black from your black lists.
        /// </summary>
        /// <remarks>Data = the ip or hwid | Set type 0=ip 1=hwid</remarks>
        /// <param name="data">Blacklisted data here</param>
        /// <param name="type">Type of blacklist data being deleted, either ip(int 0) or hwid(int 1).</param>
        public void BlackDelete(string data, string type)
        {
            /*string ipHwid = string.Empty;
            if (type == 0)
                ipHwid = "ip";
            else if (type == 1)
                ipHwid = "hwid";*/
            string url = $"?sellerkey={_sellerKey}&type=delblack&data={data}&blacktype={type}";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
        }
        /// <summary>
        /// Deletes all blacks from your black lists.
        /// </summary>
        public void BlackDelectAll()
        {
            string url = $"?sellerkey={_sellerKey}&type=delblacks";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
        }
        /// <summary>
        /// Fetch all blacks from your black lists.
        /// </summary>
        public void BlackViewAll()
        {
            string url = $"?sellerkey={_sellerKey}&type=fetchallblacks";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            if (json.Success)
            {
                string list = string.Empty;
                string type = string.Empty;
                int number = 1;
                var jsonBlacks = JsonConvert.DeserializeObject<BlacksStructure>(response);
                foreach (var black in jsonBlacks.Subs)
                {
                    if(black.Type == "ip")
                         type += $"Black {number++}: IP = {black.Ip}" + "\n";
                    if (black.Type == "hwid")
                        type += $"Black {number++}: HWID = {black.Hwid}" + "\n";
                }
                list += type;
                jsonBlacks.List = list;
                jsonBlacks.Total = jsonBlacks.Subs.Count;
                LoadBlackStruct(jsonBlacks);
            }
            LoadResponseStruct(json);
        }
        #endregion

        #region Settings
        /// <summary>
        /// Retrieves the settings from the selected application.
        /// </summary>
        /// <remarks>Things that do not work are: Download link | Paused app msg | sellix day product ID | sellix week product ID | sellix month product ID | sellix lifetime product ID</remarks>
        public void SettingsView()
        {
            string url = $"?sellerkey={_sellerKey}&type=getsettings";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            if (json.Success)
            {
                var jsonSettings = JsonConvert.DeserializeObject<SettingsStructure>(response);
                var test = JObject.Parse(response);
                jsonSettings.HwidLock = (bool)test["hwid-lock"];
                string list = "Settings: " +
                    $"\nApp Enabled: {jsonSettings.Enabled}" +
                    $"\nHWID Lock: {jsonSettings.HwidLock}" +
                    $"\nVersion: {jsonSettings.Version}" +
                    $"\nWeb Hook: {jsonSettings.Webhook}" +
                    $"\nReseller Store: {jsonSettings.Resellerstore}" +
                    $"\nDisabled Msg: {jsonSettings.Disabledmsg}" +
                    $"\nUsername Taken Msg: {jsonSettings.Usernametakenmsg}" +
                    $"\nLicense Invalid Msg: {jsonSettings.Licenseinvalidmsg}" +
                    $"\nKey Taken Msg: {jsonSettings.Keytakenmsg}" +
                    $"\nNo Sub Msg: {jsonSettings.Nosubmsg}" +
                    $"\nUser Invalid Msg: {jsonSettings.Userinvalidmsg}" +
                    $"\nPass Invalid Msg: {jsonSettings.Passinvalidmsg}" +
                    $"\nHwid Mismatch Msg: {jsonSettings.Hwidmismatchmsg}" +
                    $"\nNo Active Sub Msg: {jsonSettings.Noactivesubmsg}" +
                    $"\nBlacked Msg: {jsonSettings.Blackedmsg}" +
                    $"\nExpired Msg: {jsonSettings.Expiredmsg}" +
                    $"\nSellix Secret: {jsonSettings.Sellixsecret}";
                jsonSettings.List = list;
                LoadSettingsStruct(jsonSettings);
            }
            LoadResponseStruct(json);
        }
        /// <summary>
        /// Updates all the settings for the selected application. Leave the string blank to not change the setting !!
        /// </summary>
        /// <param name="appEnabled"></param>
        /// <param name="hwidLockEnabled"></param>
        /// <param name="version"></param>
        /// <param name="webHook"></param>
        /// <param name="resellerStore"></param>
        /// <param name="disabledMsg"></param>
        /// <param name="usernameTakenMsg"></param>
        /// <param name="licenseInvalidMsg"></param>
        /// <param name="blackedMsg"></param>
        /// <param name="expiredMsg"></param>
        /// <param name="hwidMismatchMsg"></param>
        /// <param name="keyTakenMsg"></param>
        /// <param name="noActiveSubMsg"></param>
        /// <param name="noSubMsg"></param>
        /// <param name="passInvalidMsg"></param>
        /// <param name="sellixSecret"></param>
        /// <param name="userInvalidMsg"></param>
        public void SettingsUpdate(string version, string webHook, string resellerStore, string disabledMsg, string usernameTakenMsg, string licenseInvalidMsg, string keyTakenMsg, string noSubMsg, string userInvalidMsg, string passInvalidMsg, string hwidMismatchMsg, string noActiveSubMsg, string blackedMsg, string expiredMsg, string sellixSecret)
        {
            string url = $"?sellerkey={_sellerKey}&type=updatesettings&ver={version}&webhook={webHook}&resellerstore={resellerStore}&appdisabled={disabledMsg}&usernametaken={usernameTakenMsg}&keynotfound={licenseInvalidMsg}&keyused={keyTakenMsg}&nosublevel={noSubMsg}&usernamenotfound={userInvalidMsg}&passmismatch={passInvalidMsg}&hwidmismatch={hwidMismatchMsg}&noactivesubs={noActiveSubMsg}&hwidblacked={blackedMsg}&keyexpired={expiredMsg}&sellixsecret={sellixSecret}";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            if (json.Success)
                SettingsView();
            LoadResponseStruct(json);
        }
        /// <summary>
        /// Quickly enables or disables HWID Lock.
        /// </summary>
        /// <param name="hwidLockEnabled">True or False bool</param>
        public void HwidLockEnabled(bool hwidLockEnabled)
        {
            string hwidLock = string.Empty;
            if (hwidLockEnabled)
                hwidLock = "true";
            else if (!hwidLockEnabled)
                hwidLock = "false";
            string url = $"?sellerkey={_sellerKey}&type=updatesettings&hwidcheck={hwidLock}";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            if (json.Success)
                SettingsView();
            LoadResponseStruct(json);
        }
        /// <summary>
        /// Quickly enables or disables your application.
        /// </summary>
        /// <param name="appEnabled">True or False bool</param>
        public void AppEnabled(bool appEnabled)
        {
            string enabled = string.Empty;
            if (appEnabled)
                enabled = "true";
            else if (!appEnabled)
                enabled = "false";
            string url = $"?sellerkey={_sellerKey}&type=updatesettings&enabled={enabled}";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            if (json.Success)
                SettingsView();
            LoadResponseStruct(json);
        }
        /// <summary>
        /// Quickly set your application version.
        /// </summary>
        /// <param name="Version"> version number in a string</param>
        public void SetVersion(string Version)
        {
            string url = $"?sellerkey={_sellerKey}&type=updatesettings&ver={Version}";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
            if (json.Success)
                SettingsView();
        }
        public void SettingsDefault()
        {
            string version = "1.0";
            string webHook = "None";
            string resellerStore = "None";
            string disabledMsg = "This application is disabled.";
            string usernameTakenMsg = "Username Already Exists.";
            string licenseInvalidMsg = "Key Not Found.";
            string keyTakenMsg = "Key Already Used.";
            string noSubMsg = "There is no subscription created for your key level. Contact application developer.";
            string userInvalidMsg = "Username not found.";
            string passInvalidMsg = "Password does not match.";
            string hwidMismatchMsg = "HWID Doesn't match. Ask for key reset.";
            string noActiveSubMsg = "There is no subscription created for your key level. Contact application developer.";
            string blackedMsg = "You've been blacklisted from our application.";
            string expiredMsg = "There is no subscription created for your key level. Contact application developer.";
            string sellixSecret = "None";
            string url = $"?sellerkey={_sellerKey}&type=updatesettings&ver={version}&webhook={webHook}&resellerstore={resellerStore}&appdisabled={disabledMsg}&usernametaken={usernameTakenMsg}&keynotfound={licenseInvalidMsg}&keyused={keyTakenMsg}&nosublevel={noSubMsg}&usernamenotfound={userInvalidMsg}&passmismatch={passInvalidMsg}&hwidmismatch={hwidMismatchMsg}&noactivesubs={noActiveSubMsg}&hwidblacked={blackedMsg}&keyexpired={expiredMsg}&sellixsecret={sellixSecret}";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            if (json.Success)
                SettingsView();
            LoadResponseStruct(json);
        }
        #endregion

        #region Hash
        /// <summary>
        /// Adds a new hash to your application.
        /// </summary>
        /// <param name="hash">The MD5 hash you want to add</param>
        public void HashAdd(string hash)
        {
            string url = $"?sellerkey={_sellerKey}&type=addhash&hash={hash}";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
        }
        /// <summary>
        /// Resets the current hash of your application.
        /// </summary>
        /// <remarks>PS Application must have a hash to be able to reset it</remarks>
        public void HashReset()
        {
            string url = $"?sellerkey={_sellerKey}&type=resethash";
            var response = Request(url);
            var json = JsonConvert.DeserializeObject<ResponseStructure>(response);
            LoadResponseStruct(json);
        }
        #endregion

        #region BaseRequest
        /// <summary>
        /// Retrieves the settings from the selected application.
        /// </summary>
        /// <param name="url">Reguest url the part the comes after the base address, example ?sellerkey={sellerkey}&type=getsettings </param>
        private static string Request(string url)
        {
            string baseAddress = $"https://keyauth.win/api/seller/"+ url;
            var rawResponse = Client.GetAsync(baseAddress).Result;
            string data = rawResponse.Content.ReadAsStringAsync().Result;
            Console.WriteLine(data);
            if (rawResponse.StatusCode == (HttpStatusCode)403)
            {
                var error = JObject.Parse(data);
                Error(error["message"].ToString());
                return null;
            }
            else if (rawResponse.StatusCode == (HttpStatusCode)502)
            {
                var error = JObject.Parse(data);
                Error(error["message"].ToString());
                return null;
            }
            else if (data.Contains("error code: 1015"))
            {
                Error(data);
                return null;
            }
            return data;
        }

        #endregion

        #region HttpClientClient
        private static HttpClient Client { get; set; }
        /// <summary>
        /// Starts up the HTTPClient must be called before any other function.
        /// </summary>
        public void InitClient()
        {
            Client = new HttpClient();
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        #endregion

        #region Errors
        /// <summary>
        /// Used to display errors to user.
        /// </summary>
        /// <param name="message">The error message to show the user</param>
        public static void Error(string message)
        {
            Process.Start(new ProcessStartInfo("cmd.exe", $"/c start cmd /C \"color 4 && title Error && echo {message} && timeout /t 10\"")
            {
                CreateNoWindow = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false
            });
            Environment.Exit(0);
        }
        #endregion

        #region LicenseStruct
        public LicenseClass license = new LicenseClass();
        public class LicenseClass
        {
            public int Total { get; set; }
            public Info Info { get; set; }
            public List<Keys> Keys { get; set; }
            public string Key { get; set; }
            public string List { get; set; }


        }
        private void LoadLicenseStruct(LicenseStructure data)
        {
            license.Info = data.Info;
            license.Keys = data.Keys;
            license.List = data.List;
            license.Total = data.Total;
            license.Key = data.Key;
        }
        public KeysClass keys = new KeysClass();
        public class KeysClass
        {
            public string Key { get; set; }
            public List<string> Keys { get; set; }
            public string List { get; set; }
        }
        private void LoadKeysStruct(KeysStructure data)
        {
            keys.Key = data.Key;
            keys.List = data.List;
            keys.Keys = data.Keys;
        }
        #endregion

        #region UsersStruct
        public UsersClass users = new UsersClass();

        public class UsersClass
        {
            public string List { get; set; }
            public int Total { get; set; }
            public List<Var> AllVars { get; set; }
            public string Response { get; set; }
            public List<User> Users { get; set; }
            public string Username { get; set; }

            public string Ip { get; set; }

            public string Hwid { get; set; }

            public string Createdate { get; set; }

            public string Lastlogin { get; set; }
            public List<UserSubs> Subscriptions { get; set; }
            public List<string> Usernames { get; set; }
        }
        private void LoadUsersStruct(UsersStructure data)
        {
            users.List = data.List;
            users.Response = data.Response;
            users.Total = data.Total;
            users.Users = data.Users;
            users.AllVars = data.Vars;
            users.Username = data.Username;
            users.Subscriptions = data.Subscriptions;
            users.Ip = data.Ip;
            users.Hwid = data.Hwid;
            users.Createdate = data.Createdate;
            users.Lastlogin = data.Lastlogin;
            users.Usernames = data.Usernames;
        }
        #endregion

        #region SubsStruct
        public SubsClass subs = new SubsClass();

        public class SubsClass
        {
            public string List { get; set; }
            public int Total { get; set; }
            public List<Sub> All { get; set; }
        }
        private void LoadSubStruct(SubsStructure data)
        {
            subs.List = data.List;
            subs.All = data.Subs;
            subs.Total = data.Total;
        }
        #endregion

        #region FilesStruct
        public FilesClass files = new FilesClass();

        public class FilesClass
        {
            public string List { get; set; }
            public int Total { get; set; }
            public List<Docs> All { get; set; }
        }
        private void LoadFileStruct(FilesStructure data)
        {
            files.List = data.List;
            files.All = data.Files;
            files.Total = data.Total;
        }
        #endregion

        #region VariablesStruct
        public VariablesClass variables = new VariablesClass();

        public class VariablesClass
        {
            public string List { get; set; }
            public int Total { get; set; }
            public List<Vars> All { get; set; }
        }
        private void LoadVariablesStruct(VariablesStructure data)
        {
            variables.List = data.List;
            variables.All = data.Vars;
            variables.Total = data.Total;
        }
        #endregion

        #region BlacksStruct
        public BlacksClass blacks = new BlacksClass();

        public class BlacksClass
        {
            public string List { get; set; }
            public int Total { get; set; }
            public List<BlackSub> All { get; set; }
        }
        private void LoadBlackStruct(BlacksStructure data)
        {
            blacks.List = data.List;
            blacks.Total = data.Total;
            blacks.All = data.Subs;
        }
        #endregion

        #region AppStatsStruct
        public AppStatsClass Stats = new AppStatsClass();
        public class AppStatsClass
        {
            public string Unused { get; set; }
            public string Used { get; set; }
            public string Paused { get; set; }
            public string Banned { get; set; }
            public string Totalkeys { get; set; }
            public string Webhooks { get; set; }
            public string Files { get; set; }
            public string Vars { get; set; }
            public string Resellers { get; set; }
            public string Managers { get; set; }
            public string Totalaccs { get; set; }
        }
        private void LoadAppStatsStruct(AppStatsStructure data)
        {
            Stats.Unused = data.Unused;
            Stats.Used = data.Used;
            Stats.Paused = data.Paused;
            Stats.Banned = data.Banned;
            Stats.Totalkeys = data.Totalkeys;
            Stats.Webhooks = data.Webhooks;
            Stats.Files = data.Files;
            Stats.Vars = data.Vars;
            Stats.Resellers = data.Resellers;
            Stats.Managers = data.Managers;
            Stats.Totalaccs = data.Totalaccs;
        }
        #endregion

        #region SettingsStruct
        public Settingsclass settings = new Settingsclass();
        public class Settingsclass
        {
            public string List { get; set; }
            public bool AppEnabled { get; set; }
            public bool HwidLockEnabled { get; set; }
            public string Version { get; set; }
            public string Webhook { get; set; }
            public string Resellerstore { get; set; }
            public string Disabledmsg { get; set; }
            public string Usernametakenmsg { get; set; }
            public string Licenseinvalidmsg { get; set; }
            public string Keytakenmsg { get; set; }
            public string Nosubmsg { get; set; }
            public string Userinvalidmsg { get; set; }
            public string Passinvalidmsg { get; set; }
            public string Hwidmismatchmsg { get; set; }
            public string Noactivesubmsg { get; set; }
            public string Blackedmsg { get; set; }
            public string Expiredmsg { get; set; }
            public string Sellixsecret { get; set; }
        }
        private void LoadSettingsStruct(SettingsStructure data)
        {
            settings.List = data.List;
            settings.AppEnabled = data.Enabled;
            settings.HwidLockEnabled = data.HwidLock;
            settings.Version = data.Version;
            settings.Webhook = data.Webhook;
            settings.Resellerstore = data.Resellerstore;
            settings.Disabledmsg = data.Disabledmsg;
            settings.Usernametakenmsg = data.Usernametakenmsg;
            settings.Licenseinvalidmsg = data.Licenseinvalidmsg;
            settings.Keytakenmsg = data.Keytakenmsg;
            settings.Nosubmsg = data.Nosubmsg;
            settings.Userinvalidmsg = data.Userinvalidmsg;
            settings.Passinvalidmsg = data.Passinvalidmsg;
            settings.Hwidmismatchmsg = data.Hwidmismatchmsg;
            settings.Noactivesubmsg = data.Noactivesubmsg;
            settings.Blackedmsg = data.Blackedmsg;
            settings.Expiredmsg = data.Expiredmsg;
            settings.Sellixsecret = data.Sellixsecret;
        }
        #endregion

        #region ResponseStruct
        public ResponseClass response = new ResponseClass();

        public class ResponseClass
        {
            public bool Success { get; set; }
            public string Message { get; set; }
        }

        private void LoadResponseStruct(ResponseStructure data)
        {
            response.Success = data.Success;
            response.Message = data.Message;
        }
        #endregion

        public void ExecuteAsAdmin(string fileName)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = fileName;
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.Verb = "runas";
            proc.Start();
        }
        public DateTime UnixTimeToDateTime(long unixtime)
        {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
            dtDateTime = dtDateTime.AddSeconds(unixtime).ToLocalTime();
            return dtDateTime;

        }
    }

}
