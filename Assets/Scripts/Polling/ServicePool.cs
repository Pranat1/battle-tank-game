using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServicePool<T> : MonoSingletonGeneric<ServicePool<T>>
    where T: class
{
    private List<PooledItem<T>> pooledItems = new List<PooledItem<T>>();
    protected virtual T GetItem(){
        if(pooledItems.Count > 0){
            
            PooledItem<T> item = pooledItems.Find(i => i.IsUsed == false);
            if(item != null){
                return item.Item;
            }

            // create a new item and add to pool
        }
        return CreateNewPooledItem();
    }
    public T CreateNewPooledItem(){
        PooledItem<T> pooledItem = new PooledItem<T>();
        pooledItem.Item = CreateItem();
        pooledItem.IsUsed = true;
        pooledItems.Add(pooledItem);
        return pooledItem.Item;
    }
    public virtual void ReturnItem(T item){
        PooledItem<T> pooledItem = pooledItems.Find(i => i.Item.Equals(item)); 
        pooledItem.IsUsed = false;
    }

    protected virtual T CreateItem(){
        return (T) null;
    }

    public class PooledItem<T>{
        public T Item;
        public bool IsUsed;
  }
}

