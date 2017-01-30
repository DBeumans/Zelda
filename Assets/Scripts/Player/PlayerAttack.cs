public class PlayerAttack : InputBehaviour
{

	private bool _attack = false;

    bool _canAttack = true;

	public bool attack { get { return _attack; } set { _attack = value; } }
    public bool CanAttack { get { return _canAttack; } set { _canAttack = value; } }

    void Update()
    {
        KeysCheck();
        if (_mouseButton1 && !_attack && _canAttack)
        {
            _attack = true;
        }

    }


}
