## 二分法（Bisection method） 即一分为二的方法，又可以被称为二分查找，它描述了在有序集合中搜索特定值的过程。广义的二分查找是将问题的规模尽可能的缩小到原有的一半。

### 基本思想：

假设数据是按升序排序的，对于给定值key，从序列的中间位置mid开始比较

如果当前位置arr[mid]值等于key，则查找成功；

若key小于当前位置值arr[mid]，则在数列的前半段中查找,arr[low,mid-1]；

若key大于当前位置值arr[mid]，则在数列的后半段中继续查找arr[mid+1,high]，

直到找到为止,时间复杂度:O(log(n))


左闭右闭
L -1 < target -> L <= target
R + 1 >= target -> R < target