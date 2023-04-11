using System.Collections.Generic;

namespace String.模拟
{
    /*https://leetcode.cn/problems/keys-and-rooms/description/*/
    public class 钥匙和房间
    {
        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            var vistedRoom = new bool[rooms.Count];
            dfs(rooms, 0, vistedRoom);
            for (var i = 0; i < vistedRoom.Length; i++)
            {
                if (!vistedRoom[i])
                {
                    return false;
                }
            }

            return true;
        }

        void dfs(IList<IList<int>> rooms, int index, bool[] visited)
        {
            var keys = rooms[index];
            visited[index] = true;
            for (var i = 0; i < keys.Count; i++)
            {
                var nextRoom = keys[i];
                if (!visited[nextRoom])
                {
                    dfs(rooms, nextRoom, visited);
                }
            }
        }
    }
}