using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
 *  Turtle class
 *  
 *  Stores reference of Specific Coin, four Quiz instance.
 *  
 *  
 *  Last Modification
 *  19-3-28, 10:19  Serim
 *            3:30  Serim
 */


/**
 *  Singleton Class Pattern
 *  for more info
 *  <see cref="https://csharpindepth.com/Articles/Singleton"/>
 */
public sealed class ItemRefs
{
    private static readonly Lazy<ItemRefs>
        lazy =
        new Lazy<ItemRefs>
            (() => new ItemRefs());

    public static ItemRefs Instance { get { return lazy.Value; } }
    public readonly Dictionary<string, Item> items;

    private ItemRefs()
    {
        coinInit();
    }

    private void coinInit()
    {
        items.Add("01-001", new Coin( "", "진리 코인", "stub" ) );
        items.Add("01-002", new Coin( "", "지선 코인", "stub" ) );
        items.Add("01-003", new Coin( "", "창의적 전문인 코인", "stub" ) );
        items.Add("01-004", new Coin( "", "포용적 사회인 코인", "stub" ) );
        items.Add("01-005", new Coin( "", "열린 세계인 코인", "stub" ) );
        items.Add("01-006", new Coin( "", "창의융합 역량 코인", "stub" ) );
        items.Add("01-007", new Coin( "", "공동체 역량 코인", "stub" ) );
        items.Add("01-008", new Coin( "", "글로벌 역량 코인", "stub" ) );
        items.Add("01-009", new Coin( "", "창의력 코인", "stub" ) );
        items.Add("01-010", new Coin( "", "용합능력 코인", "stub" ) );
        items.Add("01-011", new Coin( "", "자기관리능력 코인", "stub" ) );
        items.Add("01-012", new Coin( "", "대인관계능력 코인", "stub" ) );
        items.Add("01-013", new Coin( "", "글로벌 소통능력 코인", "stub" ) );
        items.Add("01-014", new Coin( "", "글로벌 시민의식 코인", "stub" ) );
        items.Add("01-015", new Coin( "", "상상력 인큐베이터 코인", "stub" ) );
        items.Add("01-016", new Coin( "", "공동선 추구 코인", "stub" ) );
        items.Add("01-017", new Coin( "", "창조적 인재 코인", "stub" ) );
    }
}

class Inventory
{
    public Slot[] itemSlots;
    internal Slot Transfer(Item obj, ref int amount) { return null; }
    public void Get(Item obj, int amount) { }
    public void Discard(Item obj, int amount) { }

    private void Add() { }
    public class Slot
    {
        [Range(0, 255)]
        int amount;
        Item obj;
    }
}

namespace NPC
{
    public class Turtle : Actor
    {
        public TurtleType Turtle_t { get; set; }
        private Inventory storage;

        public Queue<Quiz> quizQ = null;

        public DateTime IncorrectMoment;
        public AlertTimer TimerRef = null;

        public Turtle(TurtleType type = TurtleType.Regular)
        {
            switch (type) {
                default:
                case TurtleType.Regular:
                case TurtleType.TSampleA:
                case TurtleType.TSampleB:
                    storage.Get(ItemRefs.Instance.items["01-001"] , 1);
                    break;

                case TurtleType.Boss:
                    storage.Get(ItemRefs.Instance.items["01-017"] , 1);

                    break;
            }
        }
        

        Quiz RequestQuiz() {
            if (quizQ == null) {
                
            }
            if (quizQ.Count == 0) {
                
            }
            

        }
        void GiveUpLoot() { }
        void FaintForSeconds() { }

        private void SetNewTimer(int duration)
        {
            TimerRef = new AlertTimer( duration );
            if (!TimerRef) {
                throw new TypeInitializationException( "AlertTimer", null );
            }

        }
    }

    public enum TurtleType {
        Regular = -1, TSampleA, TSampleB,
        Boss
    }

}