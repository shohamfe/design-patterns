using BasicFacebookFeatures.Logic.Models;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using static FacebookWrapper.ObjectModel.User;

namespace BasicFacebookFeatures.Interfaces
{
    public interface IUser
    {
        FacebookObjectCollection<User> Friends { get; }
        FacebookObjectCollection<Album> Albums { get; }
        FacebookObjectCollection<Page> LikedPages { get; }
        FacebookObjectCollection<Post> Posts { get; }
        string Name { get; }
        string FirstName { get; }
        string LastName { get; }
        string MiddleName { get; }
        string Link { get; }
        eGender Gender { get; }
        string Birthday { get; }
        string Email { get; }
        eRelationshipStatus RelationshipStatus { get; }
        City Hometown { get; }
        Page[] Languages { get; }
        string PictureSmallURL { get; }
        string PictureNormalURL { get; }
        string PictureLargeURL { get; }
        string PictureSquareURL { get; }
        string Id { get; }
        List<PostDetails> FeedPosts { get; }
        List<PostDetails> CloseFriendsFeedPosts { get; }
        HashSet<string> CloseFriendsIdSet { get; }

        void UpdateCloseFriendState(string i_UserId, bool i_IsCloseFriend);
    }
}
