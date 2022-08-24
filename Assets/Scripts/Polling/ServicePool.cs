/* using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServicePool<T> : MonoSingletonGeneric<ServicePool<T>>
{
    private List<PooledItem<T>> pooledItems;
    protected virtual T GetItem(){
        PooledItem<T> item = pooledItems.Find(i => i.IsUsed == false);
        if(item != null){
            return item.Item;
        }

        // create a new item and add to pool
        return CreateNewPooledItem();


    }
    public T CreateNewPooledItem(){
        PooledItem<T> PooledItem = new PooledItem<T>();
        pooledItem.Item = CreateItem();
        pooledItem.IsUsed = true;
        pooledItems.Add(pooledItem);
        return pooledItem.Item;
    }
    public virtual void ReturnItem(){

    }

    protected virtual T CreateItem(){
        return (T) null;
    }
}

public class PooledItem<T>{
    public T item;
    public bool IsUsed;
}
 */