//
//
//  Generated by StarUML(tm) C# Add-In
//
//  @ Project : OSite
//  @ File Name : ICommentDAL.cs
//  @ Date : 2011/8/23
//  @ Author : 
//
//

using System.Data;

namespace JR.Cms.Library.DataAccess.IDAL
{
    public interface ICommentDAL
    {
        void Add(string archiveID, int memberID, string ip, string content, bool recycle);

        /// <summary>
        /// ��ȡ�ĵ�����
        /// </summary>
        /// <param name="archiveId"></param>
        /// <param name="desc">�Ƿ���</param>
        /// <returns></returns>
        DataTable GetArchiveComments(string archiveID, bool desc);

        int GetArchiveCommentsCount(string archiveID);

        //void Update();
        void Delete(int id);
        void DeleteMemberComments(int memberID);
        void DeleteArchiveComments(string archiveID);
    }
}