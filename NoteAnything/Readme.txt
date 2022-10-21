프로그램 구조
프로그램 작성시 참고 바람.
※클래스 1개당 한 사람이 할당
partial 클래스는 허용X

Form_A.cs 파일
네임스페이스
{
    interface AA, BB
    {
        void AA_1();
        void AsA_1();
        int BB_1();
    }

    partial FormClass : Form // 폼
    {
        public Main() //메인 함수
        {
            '''
            Main() // 생성자
            {
                '''
            }
        }
        private EventHandle(이벤트)
        {
            '''
            AA.method();
        }
    }
}

/// A1.cs 외부 사용자 정의 클래스 파일
class AA // 사용자 정의 클래스
{
    public void AA_1() //사용자 정의 메소드
    {
        '''
    }
}
class BB // 사용자 정의 클래스
{
    public int BB_1() //사용자 정의 메소드
    {
        '''
    }
}
///

/// C1.cs
class CC // 사용자 정의 클래스
{
    public int CC_1() //사용자 정의 메소드
    {
        '''
    }
}
///

Form_A_partial.cs // 파일 이름 : [폼이름]_partial.cs
partial class FormClass 사용자 정의 메소드
{
    
}
