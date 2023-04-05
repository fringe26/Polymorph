namespace Polymorph
{
    interface IEnemy  // methodlar 
    {
        public void Attack();
        public void ShowSkill(ISkill skill);
        public ISkill GetSkill();
     
    }

}
