using System;

namespace StateDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
           Context context=new Context();
           //Modified State
           ModifiedState modifiedState=new ModifiedState();
           modifiedState.DoAction(context);
           //Deleted State
           DeletedState deletedState=new DeletedState();
           deletedState.DoAction(context);

           Console.WriteLine(context.GetState().ToString());
        }
    }
    interface IState
    {
        void DoAction(Context context);
    }

     class ModifiedState : IState
     {
          public void DoAction(Context context)
          {
               Console.WriteLine("State:Modified");
               context.SetState(this);
          }
          public override string ToString()
          {
               return "Modified";
          }
     }

       class AddedState : IState
     {
          public void DoAction(Context context)
          {
               Console.WriteLine("State:Added");
               context.SetState(this);
          }
            public override string ToString()
          {
               return "Added";
          }
     }

       class DeletedState : IState
     {
          public void DoAction(Context context)
          {
               Console.WriteLine("State:Deleted");
               context.SetState(this);
          }
            public override string ToString()
          {
               return "Deleted";
          }
     }


     class Context
    {
        private IState _state;
        public void SetState(IState state)
        {
            _state=state;
        }
        public IState GetState()
        {
            return _state;
        }
    }
}
