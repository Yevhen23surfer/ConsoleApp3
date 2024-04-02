class HeroMonsterBattle
{
    static void Main(string[] args)
    {
        int heroHealth = 10;
        int monsterHealth = 10;

        do
        {
            // Hero attacks monster
            int attackValue = new Random().Next(1, 11); //Generate random attack value (1-10)
            monsterHealth -= attackValue;
            Console.WriteLine($"Hero attacks for {attackValue} damage! Monster was damaged and lost {attackValue} health and now has {monsterHealth} health.");

            // Check if monster is still alive
            if (monsterHealth <= 0) continue;

            // Monster attacks hero
            attackValue = new Random().Next(1, 11);
            heroHealth -= attackValue;
            Console.WriteLine($"Hero was damaged and lost {attackValue} health and now has {heroHealth} health.");
        } while (heroHealth > 0 && monsterHealth > 0);

        // Determine winner
        if (monsterHealth <= 0)
        {
            Console.WriteLine("Hero wins!");
        }
        else
        {
            Console.WriteLine("Monster wins!");
        }
    }
}