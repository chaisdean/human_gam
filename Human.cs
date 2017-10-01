namespace human_NEW
{
    public class human
    {
        public string name;
        public int strength = 3;
        public int intelligence = 3;
        public int dexterity = 3;
        public int health = 100;

        // public human(string val)
        // {
        //     name = val;
        // }

        public human(string i, int str, int intl, int dex, int helth)
        {
            name = i;
            strength = str;
            intelligence = intl;
            dexterity = dex;
            health = helth;
        }

        public void attack(object val)
        {
            human enemy = val as human;
            int attack = 5 * strength;
            if(enemy != null)
            {
                enemy.health = 5 * strength;
            }
        }

    }
    
}







