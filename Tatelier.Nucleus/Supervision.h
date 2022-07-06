#pragma once

#include <stdint.h>

class SceneControlMaster;

class Supervision {
	Supervision(const Supervision& a) { }
	Supervision() { }
	SceneControlMaster* sceneControl;
	int64_t nowMicroSecTime;
	int32_t nowMillisecTime;

public:
	static Supervision& GetInstance();

	/**
	 * @brief �R�}���h����&���s
	 */
	int32_t CommandSearchAndRun(const char* command, ...);

	/**
	 * @brief ����������
	 */
	void Start();

	/**
	 * @brief �X�V����
	 * @detail ���t���[���Ăяo������
	 */
	void Update();

	/**
	 * @brief �`�揈��
	 * @detail ���t���[���Ăяo������
	 */
	void Draw();
	/**
	 * @brief ���݂̃}�C�N���b
	 */
	int64_t GetNowMicroTime();
	/**
	 * @brief ���݂̃~���b
	 */
	int32_t GetNowMillisecTime();
};